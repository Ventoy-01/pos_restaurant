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
                // 1. Validation simple
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                {
                    AfficherMessage("Le nom est obligatoire", Color.Red);
                    txtNom.Focus();
                    return;
                }
                
                if (!Double.TryParse(txtPrix.Text, out Double prix) || prix <= 0)
                {
                    AfficherMessage("Prix invalide (doit être > 0)", Color.Red);
                    txtPrix.Focus();
                    return;
                }
                
                // 2. Créer l'objet Model à partir des contrôles UI
                MenusModel nouveauMenu = new MenusModel
                {
                    Nom = txtNom.Text.Trim(),
                    Type = comboType.Text,
                    PrixUnitaire = prix,
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
    }
}