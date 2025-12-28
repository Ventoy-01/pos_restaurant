using System;
using System.Windows.Forms;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

namespace Pos_Restaurant.Views.Users
{
    public partial class ModifierUserForm : Form
    {
        private UsersModel userCourant;
        private UsersController controller;

        public ModifierUserForm(UsersModel user)
        {
            InitializeComponent();
            controller = new UsersController();
            userCourant = user;
            ChargerUserDansFormulaire();
        }

        private void ChargerUserDansFormulaire()
        {
            txtUsername.Text = userCourant.Username;
            comboRole.Text = userCourant.Role;
            
            txtPassword.PlaceholderText = "Laissez vide pour ne pas modifier";
            txtConfirmPassword.PlaceholderText = "Laissez vide pour ne pas modifier";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!ValiderFormulaire())
                return;

            try
            {
                // Mise à jour des informations de base
                userCourant.Username = txtUsername.Text.Trim();
                userCourant.Role = comboRole.Text;

                // Mise à jour du mot de passe seulement si spécifié
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    userCourant.Password = txtPassword.Text;
                }

                bool succes = controller.ModifierUser(userCourant);

                if (succes)
                {
                    MessageBox.Show("Utilisateur modifié avec succès !", "Succès", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Échec de la modification.", "Erreur", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValiderFormulaire()
        {
            // Validation du nom d'utilisateur
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("👤 Le nom d'utilisateur est obligatoire.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (txtUsername.Text.Length < 3)
            {
                MessageBox.Show("👤 Le nom d'utilisateur doit avoir au moins 3 caractères.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                txtUsername.SelectAll();
                return false;
            }

            // Validation du mot de passe (si modifié)
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (txtPassword.Text.Length < 4)
                {
                    MessageBox.Show("🔒 Le mot de passe doit avoir au moins 4 caractères.", 
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return false;
                }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("🔒 Les mots de passe ne correspondent pas.", 
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    txtConfirmPassword.SelectAll();
                    return false;
                }
            }

            // Validation du rôle
            if (string.IsNullOrEmpty(comboRole.Text))
            {
                MessageBox.Show("👑 Veuillez sélectionner un rôle.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboRole.Focus();
                return false;
            }

            return true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}