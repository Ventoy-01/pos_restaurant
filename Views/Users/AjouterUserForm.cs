using System;
using System.Windows.Forms;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

namespace Pos_Restaurant.Views.Users
{
    public partial class AjouterUserForm : Form
    {
        private UsersController controller;

        public AjouterUserForm()
        {
            InitializeComponent();
            controller = new UsersController();
            InitialiserFormulaire();
        }

        private void InitialiserFormulaire()
        {
            comboRole.SelectedIndex = 0;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!ValiderFormulaire())
                return;

            try
            {
                var user = new UsersModel
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text,
                    Role = comboRole.Text
                };

                bool succes = controller.EnregistrerUser(user);

                if (succes)
                {
                    MessageBox.Show("Utilisateur ajouté avec succès !", "Succès", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(" Échec de l'ajout de l'utilisateur.", "Erreur", 
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

            // Validation du mot de passe
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Le mot de passe est obligatoire.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("Le mot de passe doit avoir au moins 4 caractères.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                txtPassword.SelectAll();
                return false;
            }

            // Validation de la confirmation
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                txtConfirmPassword.SelectAll();
                return false;
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

        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderFormulaire();
        }

        private void ViderFormulaire()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            comboRole.SelectedIndex = 0;
            txtUsername.Focus();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}