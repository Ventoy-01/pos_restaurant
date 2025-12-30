namespace Pos_Restaurant.Views.Users;

using System;
using System.Windows.Forms;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;


    public partial class Login : Form
    {
        private UsersController controller;

        public Login()
        {
            InitializeComponent();
            controller = new UsersController();
            
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        // Choisissez une icône : 👤, 🔐, 🏪, 🍽️, etc.

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validation
            if (string.IsNullOrEmpty(username))
            {
                AfficherMessage("👤 Veuillez entrer votre nom d'utilisateur",
                    "Champ requis",  MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                AfficherMessage("🔒 Veuillez entrer votre mot de passe","Champ requis", MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                // Authentification
                bool result = (bool)controller.Authentifier(username, password)[0];
                var utilisateur = controller.Authentifier(username, password)[1];


                if (result)
                {
                    UsersModel user = (UsersModel)utilisateur;
                    AfficherMessage($"Bienvenue, {user.Username} !",
                        "Connexion réussie",  MessageBoxIcon.Information);

                    // Stocker l'utilisateur connecté (dans une classe statique par exemple)
                    SessionUtilisateur.UtilisateurCourant = user;

                    //appel a la Mainform
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    AfficherMessage(" Nom d'utilisateur ou mot de passe incorrect",
                        "Échec de connexion",  MessageBoxIcon.Error);
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                AfficherMessage($" Erreur de connexion : {ex.Message}",
                    "Erreur",  MessageBoxIcon.Error);
            }
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            AfficherMessage("📧 Veuillez contacter l'administrateur pour réinitialiser votre mot de passe.",
                "Mot de passe oublié",  MessageBoxIcon.Information);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.FromArgb(255, 250, 240);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Permettre la connexion avec la touche Entrée
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            // Permettre la navigation avec Tab et Entrée
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true; // Empêcher le bip
            }
        }
        

        private void AfficherMessage(string message, string titre, MessageBoxIcon icone = MessageBoxIcon.Information)
        {
            MessageBox.Show(message, titre, MessageBoxButtons.OK, icone);
        }
}
