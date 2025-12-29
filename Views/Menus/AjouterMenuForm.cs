// Views/AjouterMenuForm.cs
using System;
using System.Drawing;
using System.Windows.Forms;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

namespace Pos_Restaurant.Views.Menus
{
    public partial class AjouterMenuForm : Form
    {
        private MenusController controller;
        
        public AjouterMenuForm()
        {
            InitializeComponent(); 
            controller = new MenusController();
        }
        
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderSaisieMenu())
                {
                    return;
                }
                
                // 2. Créer l'objet Model à partir des contrôles UI
                MenusModel nouveauMenu = new MenusModel
                {
                    Nom = txtNom.Text.Trim(),
                    Type = comboType.Text,
                    PrixUnitaire = Convert.ToDouble(txtPrix.Text),
                    Quantite = (int)txtQuantite.Value,
                    Description = txtDescription.Text.Trim()
                };
                
                // 3. Afficher message d'attente
                AfficherMessage("⏳ Enregistrement en cours...", Color.Blue);
                this.Refresh(); 
                
                // 4. Appeler le contrôleur avec l'objet
                bool succes = controller.Enregistrer(nouveauMenu);
                
                // 5. Gérer la réponse
                if (succes)
                {
                    AfficherMessage($"Menu '{nouveauMenu.Nom}' enregistré avec succès!", 
                                   Color.Green);
                    ViderFormulaire();
                }
                else
                {
                    AfficherMessage("Échec de l'enregistrement", Color.Red);
                }
            }
            catch (FormatException)
            {
                AfficherMessage("Format de prix invalide", Color.Red);
            }
            catch (ArgumentException ex)
            {
                AfficherMessage($"Validation: {ex.Message}", Color.Orange);
            }
            catch (Exception ex)
            {
                AfficherMessage($"Erreur: {ex.Message}", Color.Red);
            }
        }
        
        private void AfficherMessage(string message, Color color)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = color;
        }
        
        private void ViderFormulaire()
        {
            txtNom.Clear();
            txtPrix.Clear();
            txtDescription.Clear();
            txtQuantite.Value = 0;
            comboType.SelectedIndex = -1;
            txtNom.Focus();
        }
        
        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderFormulaire();
        }
        private bool ValiderSaisieMenu()
        {
            // 1. Vérification du Nom (non vide)
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom du menu est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            // 2. Vérification du Prix (doit être un nombre > 0)
            if (!double.TryParse(txtPrix.Text, out double prix) || prix <= 0)
            {
                MessageBox.Show("Veuillez saisir un prix valide supérieur à 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrix.Focus();
                return false;
            }

            // 3. Vérification de la Quantité (NumericUpDown)
            if (txtQuantite.Value <= 0)
            {
                MessageBox.Show("La quantité doit être supérieure à 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantite.Focus();
                return false;
            }

            // 4. Vérification de la Catégorie (ComboBox)
            if (comboType.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un type de menu.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboType.Focus();
                return false;
            }

            return true; 
        }

    }
}