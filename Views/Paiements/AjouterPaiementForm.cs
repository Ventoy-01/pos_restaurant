using System;
using System.Windows.Forms;
using Pos_Restaurant.Models;
using System.Linq;
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
            commandesController = new CommandesController();
            InitialiserFormulaire();
            
        }

        private void InitialiserFormulaire()
        {
            // Initialiser la date à aujourd'hui
            dtpDatePaiement.Value = DateTime.Today;
            dtpDatePaiement.MaxDate = DateTime.Today.AddDays(1).AddTicks(-1); 

            
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
                comboIdCommande.Items.Clear();
                
               List <CommandesModel> commandes = commandesController.ListerCommandes();
               List<PaiementsModel> paiements = controller.ListerPaiement();
               
                // Récupérer les commandes non payées

               List<CommandesModel> commandesSansPaiement = commandes
                   .Where(cmd => !paiements.Any(pmt => pmt.IdCommande == cmd.Id))
                   .ToList();

               
               foreach (var commande in commandesSansPaiement)
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
                if (!double.TryParse(txtMontant.Text, out double montant) || montant <= 0)
                {
                    AfficherMessage("Veuillez saisir un montant valide supérieur à 0.", "Erreur",
                        MessageBoxIcon.Error);
                    return;
                }

                if (dtpDatePaiement.Value > DateTime.Now)
                {
                    AfficherMessage("La date de paiement ne peut pas être dans le futur.", "Date invalide",
                        MessageBoxIcon.Warning);
                    dtpDatePaiement.Value = DateTime.Now;
                }

                if(comboIdCommande.Items.Count <= 0){
                    AfficherMessage("Id commande incorrect", "Erreur", MessageBoxIcon.Error);
                    return;
                }

            // Créer l'objet paiement
                var paiement = new PaiementsModel
                {
                    IdCommande = ExtraireIdCommande(),
                    Montant = Convert.ToDouble(txtMontant.Text),
                    DatePaiement = dtpDatePaiement.Value,
                    ModePaiement = comboModePaiement.Text
                };
                if (paiement.Montant < ExtrairePrixTotalCommande())
                {
                    AfficherMessage($"Paiement insuffisance, Montant Total {ExtrairePrixTotalCommande()}", "Erreur", MessageBoxIcon.Error);
                    return;
                }
                if (paiement.Montant > ExtrairePrixTotalCommande())
                {
                    AfficherMessage($"Paiement Trop eleve, Montant Total {ExtrairePrixTotalCommande()}", "Erreur", MessageBoxIcon.Error);
                    return;
                }
                
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

        private Double ExtrairePrixTotalCommande()
        {
            List<CommandesModel> commandes = commandesController.ListerCommandes();
            int idCommande = ExtraireIdCommande();

            return commandes.FirstOrDefault(c => c.Id == idCommande)?.PrixTotal ?? 0.0;
        }
        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtMontant.Text, out double montantSaisi))
            {
                double prixTotalAPayer = ExtrairePrixTotalCommande();

                if (montantSaisi <= 0)
                {
                    lblStatutPrix.Text = "Veuillez saisir un montant";
                    lblStatutPrix.ForeColor = Color.Orange;
                }
                else if (montantSaisi < prixTotalAPayer)
                {
                    lblStatutPrix.Text = "Montant insuffisant (Reste : " + (prixTotalAPayer - montantSaisi).ToString("N2") + ")";
                    lblStatutPrix.ForeColor = Color.Red;
                }
                else if (montantSaisi > prixTotalAPayer)
                {
                    lblStatutPrix.Text = "Montant trop élevé (Trop-perçu : " + (montantSaisi - prixTotalAPayer).ToString("N2") + ")";
                    lblStatutPrix.ForeColor = Color.Red;
                }
                else 
                {
                    lblStatutPrix.Text = "Montant exact - Prêt à valider";
                    lblStatutPrix.ForeColor = Color.Green;
                }
            }
            else
            {
                lblStatutPrix.Text = "Saisie invalide";
                lblStatutPrix.ForeColor = Color.Red;
            }
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
            //un seul point
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