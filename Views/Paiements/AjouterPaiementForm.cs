using System;
using System.Windows.Forms;
using Pos_Restaurant.Models;
using Pos_Restaurant.Controllers;

namespace Pos_Restaurant.Views.Paiements
{
    public partial class AjouterPaiementForm : Form
    {
        private PaiementsController controller;
        private CommandesController commandesController;
        
        public AjouterPaiementForm()
        {
            InitializeComponent();
            controller = new PaiementsController();
            InitialiserFormulaire();
        }

        private void InitialiserFormulaire()
        {
            // Initialiser la date à aujourd'hui
            dtpDatePaiement.Value = DateTime.Now;
            
            
            // Initialiser le montant à 0
            txtMontant.PlaceholderText = "0.00";
            
            // Initialiser le mode de paiement par défaut
            comboModePaiement.SelectedIndex = 0;
            
            ChargerCommandes();
        }

        private void ChargerCommandes()
        {
            try
            {
                // Exemple : Récupérer les commandes non payées
                comboIdCommande.Items.Clear();
                
               List <CommandesModel> commandes = commandesController.ListerCommandes();
                foreach (var commande in commandes)
               {
                     comboIdCommande.Items.Add($"{commande.Id} - {commande.IdClient} ");
                   
               }
                
                if (comboIdCommande.Items.Count > 0)
                {
                    comboIdCommande.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                AfficherMessage($"Erreur lors du chargement des commandes : {ex.Message}.", "Erreur", MessageBoxIcon.Error);
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
        
            try
            {
                // Créer l'objet paiement
                var paiement = new PaiementsModel
                {
                    IdCommande = ExtraireIdCommande(),
                    Montant = Convert.ToDouble(txtMontant.Text),
                    DatePaiement = dtpDatePaiement.Value,
                    ModePaiement = comboModePaiement.Text
                };
        
                // Appeler le contrôleur
                bool succes = controller.AjouterPaiement(paiement);
        
                if (succes)
                {
                    AfficherMessage("Paiement enregistré avec succès !", "Succès"); 
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    AfficherMessage("Échec de l'enregistrement du paiement.", "Erreur", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AfficherMessage("Erreur lors de l'enregistrement du paiement.", "Erreur", MessageBoxIcon.Error);
            }
        }
        
        //
        private int ExtraireIdCommande()
        {
            // Extraire l'ID de commande du texte sélectionné
            // Format attendu : "ID - Description - Montant"
            if (comboIdCommande.SelectedItem != null)
            {
                string texte = comboIdCommande.SelectedItem.ToString();
                if (texte.Contains("-"))
                {
                    string idPart = texte.Split('-')[0].Trim();
                    if (int.TryParse(idPart, out int id))
                        return id;
                }
            }
            return 0;
        }
        //
        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderFormulaire();
        }
        
        private void ViderFormulaire()
        {
            txtMontant.Text = "";
            dtpDatePaiement.Value = DateTime.Now;
            comboModePaiement.SelectedIndex = 0;
            
            if (comboIdCommande.Items.Count > 0)
                comboIdCommande.SelectedIndex = 0;
            else
                comboIdCommande.Text = "";
            
            txtMontant.Focus();
        }
        //
        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permettre seulement les chiffres, le point et la touche backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        
            // Permettre un seul point décimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        
        private void AfficherMessage(string message, string titre, MessageBoxIcon icone = MessageBoxIcon.Information)
        {
            MessageBox.Show(message, titre, MessageBoxButtons.OK, icone);
        }
        
    }
}