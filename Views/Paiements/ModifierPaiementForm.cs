using System;
using System.Windows.Forms;
using Pos_Restaurant.Models;
using Pos_Restaurant.Controllers;

namespace Pos_Restaurant.Views.Paiements
{
    public partial class ModifierPaiementForm : Form
    {
        private PaiementsModel paiementCourant;
        private PaiementsController controller;
        private CommandesController commandesController ;
        
        public ModifierPaiementForm(PaiementsModel paiement)
        {
            InitializeComponent();
            controller = new PaiementsController();
            commandesController = new CommandesController();
            paiementCourant = paiement;
            ChargerPaiementDansFormulaire();
        }

        private void ChargerPaiementDansFormulaire()
        {
            // Afficher l'ID (non modifiable, juste pour information)
            lblIdPaiement.Text = $"ID: {paiementCourant.Id}";
            
            // Afficher l'ID commande (non modifiable)
            txtIdCommande.Text = paiementCourant.IdCommande.ToString();
            
            // Charger le montant
            txtMontant.Text = paiementCourant.Montant.ToString("0.00");
            
            // Charger la date
            dtpDatePaiement.Value = paiementCourant.DatePaiement;
            dtpDatePaiement.MaxDate = DateTime.Today.AddDays(1).AddTicks(-1);
            
            // Charger le mode de paiement
            comboModePaiement.Text = paiementCourant.ModePaiement;
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Validation
            if (!ValiderFormulaire())
                return;

            try
            {
                // Mise à jour de l'objet
                paiementCourant.Montant = Convert.ToDouble(txtMontant.Text);
                paiementCourant.DatePaiement = dtpDatePaiement.Value;
                paiementCourant.ModePaiement = comboModePaiement.Text;
                
                if (paiementCourant.Montant < ExtrairePrixTotalCommande())
                {
                    AfficherMessage($"Paiement insuffisance, Montant Total {ExtrairePrixTotalCommande()}", "Erreur", MessageBoxIcon.Error);
                    return;
                }
                if (paiementCourant.Montant > ExtrairePrixTotalCommande())
                {
                    AfficherMessage($"Paiement Trop eleve, Montant Total {ExtrairePrixTotalCommande()}", "Erreur", MessageBoxIcon.Error);
                    return;
                }


                // Appel contrôleur
                bool succes = controller.ModifierPaiement(paiementCourant);

                if (succes)
                {
                    AfficherMessage("Paiement modifié avec succès !", 
                        "Succès");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    AfficherMessage("Échec de la modification du paiement.", 
                        "Erreur",  MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AfficherMessage($"Erreur lors de la modification : {ex.Message}", 
                    "Erreur",  MessageBoxIcon.Error);
            }
        }

        private bool ValiderFormulaire()
        {
            // Validation de l'ID commande
            if (!int.TryParse(txtIdCommande.Text, out int idCommande) || idCommande <= 0)
            {
                AfficherMessage("ID Commande invalide.", 
                    "Validation",  MessageBoxIcon.Warning);
                txtIdCommande.Focus();
                txtIdCommande.SelectAll();
                return false;
            }

            // Validation du montant
            if (!double.TryParse(txtMontant.Text, out double montant) || montant <= 0)
            {
                AfficherMessage("Veuillez entrer un montant valide (supérieur à 0).", 
                    "Validation", MessageBoxIcon.Warning);
                txtMontant.Focus();
                txtMontant.SelectAll();
                return false;
            }

            // Validation du mode de paiement
            if (string.IsNullOrEmpty(comboModePaiement.Text))
            {
                AfficherMessage("Veuillez sélectionner un mode de paiement.", 
                    "Validation",  MessageBoxIcon.Warning);
                comboModePaiement.Focus();
                return false;
            }

            // Validation de la date (ne pas permettre les dates futures)
            if (dtpDatePaiement.Value > DateTime.Now)
            {
                AfficherMessage("La date de paiement ne peut pas être dans le futur.", 
                    "Validation",  MessageBoxIcon.Warning);
                dtpDatePaiement.Focus();
                return false;
            }
            

            return true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

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

        private void txtIdCommande_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permettre seulement les chiffres et la touche backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private Double ExtrairePrixTotalCommande()
        {
            List<CommandesModel> commandes = commandesController.ListerCommandes();
            int idCommande = txtIdCommande.Text != "" ? Convert.ToInt32( txtIdCommande.Text) : 0;

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
        
        private void AfficherMessage(string message, string titre, MessageBoxIcon icone = MessageBoxIcon.Information)
        {
            MessageBox.Show(message, titre, MessageBoxButtons.OK, icone);
        }    }
}