namespace Pos_Restaurant.Views.Paiements;

using System;
using System.Linq;
using System.Windows.Forms;
using Pos_Restaurant.Models;
using Pos_Restaurant.Controllers;


    public partial class AfficherPaiementForm : Form
    {
        private PaiementsController controller;

        public AfficherPaiementForm()
        {
            InitializeComponent();
            controller = new PaiementsController();
            ChargerPaiements();
        }

        private void ChargerPaiements()
        {
            try
            {
                var paiements = controller.ListerPaiement();
                dgvPaiements.AutoGenerateColumns = false;
                dgvPaiements.DataSource = paiements;
                
                Console.WriteLine($"Il y a {paiements.Count} paiements");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des paiements : {ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            string critere = txtRechercher.Text.Trim();
        
            if (string.IsNullOrWhiteSpace(critere))
            {
                ChargerPaiements();
                lblNombreResultats.Text = "";
                return;
            }
        
            try
            {
                var paiements = controller.ListerPaiement()
                    .Where(p => 
                        (p.Id.ToString() ?? "").Contains(critere) ||
                        (p.IdCommande.ToString() ?? "").Contains(critere) ||
                        (p.Montant.ToString("0.00") ?? "").Contains(critere) ||
                        (p.ModePaiement ?? "").Contains(critere, StringComparison.OrdinalIgnoreCase) ||
                        (p.DatePaiement.ToString("dd/MM/yyyy") ?? "").Contains(critere))
                    .ToList();
        
                dgvPaiements.DataSource = paiements;
            
                // Afficher le nombre de résultats
                lblNombreResultats.Text = $"{paiements.Count} paiement(s) trouvé(s)";
            }
            catch (Exception ex)
            {
                AfficherMessage($"Erreur lors de la recherche : {ex.Message}", "Erreur", 
                     MessageBoxIcon.Error);
            }
        }
    
        /// <summary>
        /// Logique des boutons
        /// </summary>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (AjouterPaiementForm formAjout = new AjouterPaiementForm())
            {

                // Définir le parent
                formAjout.Owner = this;

                // Ouvrir en modal
                if (formAjout.ShowDialog() == DialogResult.OK)
                {
                    // Recharger la liste après fermeture
                    ChargerPaiements();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //verifier si une ligne est selectionnée
            if (dgvPaiements.CurrentRow != null)
            {
                PaiementsModel paiement = (PaiementsModel)dgvPaiements.SelectedRows[0].DataBoundItem;

                using (ModifierPaiementForm formModif = new ModifierPaiementForm(paiement))
                {
                    formModif.Owner = this;
                    formModif.ShowDialog();
                    ChargerPaiements(); 
                }
            }
            else
            {
                AfficherMessage("Veuillez sélectionner un client à modifier.", "Erreur", MessageBoxIcon.Error);
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPaiements.SelectedRows.Count == 0)
            {
                AfficherMessage("Veuillez sélectionner un paiement à supprimer.", 
                    "Aucune sélection",  MessageBoxIcon.Warning);
                return;
            }
        
            var selectedRow = dgvPaiements.SelectedRows[0];
            
            // Récupérer les informations
            int paiementId = Convert.ToInt32(selectedRow.Cells["txtId"].Value);
           
        
            // Demander confirmation
            DialogResult dialogResult = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le paiement : {paiementId} ?", 
                "Confirmation de suppression", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);
        
            if (dialogResult == DialogResult.Yes)
            {
                try 
                {
                    // Appel au contrôleur
                    bool success = controller.SupprimerPaiement(paiementId.ToString());
                    
                    if (success)
                    {
                        AfficherMessage("Paiement supprimé avec succès !", 
                            "Succès");
                        ChargerPaiements(); // Rafraîchir la grille
                    }
                    else
                    {
                        AfficherMessage("Échec de la suppression du paiement.", 
                            "Erreur", MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    AfficherMessage($"Erreur lors de la suppression : {ex.Message}", 
                        "Erreur",  MessageBoxIcon.Error);
                }
            }
        }
    
        private void AfficherMessage(string message, string titre, MessageBoxIcon icone = MessageBoxIcon.Information)
        {
            MessageBox.Show(message, titre, MessageBoxButtons.OK, icone);
        }
}