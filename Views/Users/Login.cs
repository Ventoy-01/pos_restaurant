using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

namespace Pos_Restaurant.Views.Users
{
    public partial class Login : Form
    {
        private UsersController controller;
        
        public Login()
        {
            InitializeComponent();
            controller = new UsersController();
            InitialiserDesign();
            CentreEllipse();
        }

        private void InitialiserDesign()
        {
            // Arrondir le GroupBox
            gbloginContent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, gbloginContent.Width, gbloginContent.Height, 20, 20));
            
            // Créer l'ellipse orange en haut
            CreerEllipseOrange();
            
            // Ajouter des événements pour les effets hover
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.FromArgb(255, 149, 0);
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            
            lblForgetPassword.MouseEnter += (s, e) => lblForgetPassword.Font = new Font(lblForgetPassword.Font, FontStyle.Underline);
            lblForgetPassword.MouseLeave += (s, e) => lblForgetPassword.Font = new Font(lblForgetPassword.Font, FontStyle.Regular);
            
            // Focus sur le premier champ
            txtUsername.Focus();
        }

        private void CentreEllipse()
        {
            // Centrer le panel ellipse horizontalement
            panelEllipseTop.Left = (gbloginContent.Width - panelEllipseTop.Width) / 2;
        }

        private void CreerEllipseOrange()
        {
            // Créer un panel circulaire orange
            panelEllipseTop.Paint += (sender, e) =>
            {
                Panel panel = sender as Panel;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, panel.Width, panel.Height);
                    panel.Region = new Region(path);
                }
                
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 128, 0)))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(brush, 0, 0, panel.Width, panel.Height);
                }
                
                // Ajouter une icône dans l'ellipse (optionnel)
                using (Font font = new Font("Segoe UI Emoji", 24))
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    
                    // Choisissez une icône : 👤, 🔐, 🏪, 🍽️, etc.
                    string icon = "🔐";
                    e.Graphics.DrawString(icon, font, brush, 
                        new RectangleF(0, 0, panel.Width, panel.Height), format);
                }
            };
        }

        // Fonction native Windows pour créer des coins arrondis
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, 
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

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
                var result = (bool) controller.Authentifier(username, password)[0];
                var utilisateur = controller.Authentifier(username, password)[1];
                
                
                if (result)
                {
                    UsersModel user = (UsersModel) utilisateur;
                    MessageBox.Show($"✅ Bienvenue, {utilisateur} !", 
                        "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Stocker l'utilisateur connecté (dans une classe statique par exemple)
                    SessionUtilisateur.UtilisateurCourant = user;
                    
                    // Ouvrir le formulaire principal
                    OuvrirFormulairePrincipal();
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

        private void OuvrirFormulairePrincipal()
        {
            // Cacher le formulaire de login
            this.Hide();
            
            // Créer et afficher le formulaire principal
            var mainForm = new MainForm(); // À créer selon votre structure
            mainForm.FormClosed += (s, args) => this.Close(); // Fermer l'application quand le main form se ferme
            mainForm.Show();
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("📧 Veuillez contacter l'administrateur pour réinitialiser votre mot de passe.", 
                "Mot de passe oublié", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            // Effet visuel quand le TextBox obtient le focus
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.BackColor = Color.FromArgb(255, 250, 240); // Couleur d'accentuation
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
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

        private void Login_Resize(object sender, EventArgs e)
        {
            // Recentrer l'ellipse et le groupbox si la fenêtre est redimensionnée
            CentreEllipse();
            
            // Recentrer le groupbox
            gbloginContent.Left = (this.ClientSize.Width - gbloginContent.Width) / 2;
            gbloginContent.Top = (this.ClientSize.Height - gbloginContent.Height) / 2;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Animation d'apparition (optionnel)
            this.Opacity = 0;
            using (System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer())
            {
                fadeIn.Interval = 20;
                fadeIn.Tick += (s, ev) =>
                {
                    if (this.Opacity < 1)
                        this.Opacity += 0.05;
                    else
                        fadeIn.Stop();
                };
                fadeIn.Start();
            }
        }
    }

    // Classe pour gérer la session utilisateur (ajoutez-la dans un fichier séparé si préférez)
    public static class SessionUtilisateur
    {
        public static UsersModel UtilisateurCourant { get; set; }
        
        public static bool EstConnecte => UtilisateurCourant != null;
        
        public static bool ALeDroit(string role)
        {
            return EstConnecte && UtilisateurCourant.Role == role;
        }
        
        public static void Deconnecter()
        {
            UtilisateurCourant = null;
        }
    }

}