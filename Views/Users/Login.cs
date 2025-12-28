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
        }

        // Choisissez une icône : 👤, 🔐, 🏪, 🍽️, etc.

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("👤 Veuillez entrer votre nom d'utilisateur",
                    "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("🔒 Veuillez entrer votre mot de passe",
                    "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show($"✅ Bienvenue, {user.Username} !",
                        "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Stocker l'utilisateur connecté (dans une classe statique par exemple)
                    SessionUtilisateur.UtilisateurCourant = user;

                    //appel a la Mainform
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("❌ Nom d'utilisateur ou mot de passe incorrect",
                        "Échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Erreur de connexion : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("📧 Veuillez contacter l'administrateur pour réinitialiser votre mot de passe.",
                "Mot de passe oublié", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // private void txtUsername_Enter(object sender, EventArgs e)
        // {
        //     // Effet visuel quand le TextBox obtient le focus
        //     txtUsername.BorderStyle = BorderStyle.FixedSingle;
        //     txtUsername.BackColor = Color.FromArgb(255, 250, 240);
        // }

        // private void txtUsername_Leave(object sender, EventArgs e)
        // {
        //     txtUsername.BackColor = Color.White;
        // }

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
