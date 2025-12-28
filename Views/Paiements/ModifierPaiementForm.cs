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
        
        public ModifierPaiementForm(PaiementsModel paiement)
        {
            InitializeComponent();
            controller = new PaiementsController();
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
                


                // Appel contrôleur
                bool succes = controller.ModifierPaiement(paiementCourant);

                if (succes)
                {
                    MessageBox.Show("Paiement modifié avec succès !", 
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Échec de la modification du paiement.", 
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValiderFormulaire()
        {
            // Validation de l'ID commande
            if (!int.TryParse(txtIdCommande.Text, out int idCommande) || idCommande <= 0)
            {
                MessageBox.Show("ID Commande invalide.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCommande.Focus();
                txtIdCommande.SelectAll();
                return false;
            }

            // Validation du montant
            if (!double.TryParse(txtMontant.Text, out double montant) || montant <= 0)
            {
                MessageBox.Show("Veuillez entrer un montant valide (supérieur à 0).", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMontant.Focus();
                txtMontant.SelectAll();
                return false;
            }

            // Validation du mode de paiement
            if (string.IsNullOrEmpty(comboModePaiement.Text))
            {
                MessageBox.Show("Veuillez sélectionner un mode de paiement.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboModePaiement.Focus();
                return false;
            }

            // Validation de la date (ne pas permettre les dates futures)
            if (dtpDatePaiement.Value > DateTime.Now)
            {
                MessageBox.Show("La date de paiement ne peut pas être dans le futur.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDatePaiement.Focus();
                return false;
            }

            // Validation du statut (si applicable)
            if (comboStatut != null && string.IsNullOrEmpty(comboStatut.Text))
            {
                MessageBox.Show("Veuillez sélectionner un statut.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboStatut.Focus();
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
    }
}