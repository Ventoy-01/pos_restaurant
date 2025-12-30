using System;
using System.Drawing;
using System.Windows.Forms;
using Pos_Restaurant.Views;
using Pos_Restaurant.Views.Clients;
using Pos_Restaurant.Views.Commandes;
using Pos_Restaurant.Views.Menus;
using Pos_Restaurant.Views.Paiements;
using Pos_Restaurant.Views.Users;
using System.Globalization;

namespace Pos_Restaurant
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        private Button activeButton = null;
        private Color activeColor = Color.FromArgb(255, 128, 0);
        private Color normalColor = Color.FromArgb(64, 64, 64);
        private Color hoverColor = Color.FromArgb(100, 100, 100);
        private CultureInfo cH;

        public MainForm()
        {
            InitializeComponent();
            
            MinimumSize = new Size(this.Width, 620);
            MaximumSize = new Size(Width, 670); 
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = false;
        

            cH = new CultureInfo("fr-HT"); 
            InitialiserInterface();
            AfficherInfosUtilisateur();
        }

        private void InitialiserInterface()
        {
            // Initialiser les couleurs des boutons
            btnDashboard.BackColor = normalColor;
            btnMenus.BackColor = normalColor;
            btnClients.BackColor = normalColor;
            btnCommandes.BackColor = normalColor;
            btnPaiements.BackColor = normalColor;
            btnUsers.BackColor = normalColor;
            btnSettings.BackColor = normalColor;

            // Ouvrir le dashboard par défaut
            OuvrirFormDashboard();
            ActiverBouton(btnDashboard);

            // Ajouter des événements hover
            AjouterEffetsHover();
        }

        private void AfficherInfosUtilisateur()
        {
            if (SessionUtilisateur.EstConnecte)
            {
                lblUserName.Text = SessionUtilisateur.UtilisateurCourant.Username;
                lblUserRole.Text = SessionUtilisateur.UtilisateurCourant.Role;
            }
            else
            {
                lblUserName.Text = "Non connecté";
                lblUserRole.Text = "Invité";
            }
        }

        private void AjouterEffetsHover()
        {
            foreach (Control control in panelSidebar.Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "menu")
                {
                    button.MouseEnter += (s, e) =>
                    {
                        if (button != activeButton)
                        {
                            button.BackColor = hoverColor;
                        }
                    };

                    button.MouseLeave += (s, e) =>
                    {
                        if (button != activeButton)
                        {
                            button.BackColor = normalColor;
                        }
                    };
                }
            }
        }

        private void ActiverBouton(Button button)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = normalColor;
                activeButton.Font = new Font(activeButton.Font, FontStyle.Regular);
            }

            activeButton = button;
            activeButton.BackColor = activeColor;
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
        }

        private void OuvrirFormDashboard()
        {
            lblTitle.Text = "📊 DASHBOARD ANALYTIQUE";
            
            // Ouvrir le DashboardForm séparé
            OuvrirFormDansPanel(new DashboardForm());
        }

        private void OuvrirFormDansPanel(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            panelMain.Tag = form;
            form.BringToFront();
            form.Show();
        }

        // Événements des boutons
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiverBouton((Button)sender);
            OuvrirFormDashboard();
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            ActiverBouton((Button)sender);
            lblTitle.Text = "🍽️ MENUS";
            OuvrirFormDansPanel(new AfficherMenuForm());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ActiverBouton((Button)sender);
            lblTitle.Text = "👥 CLIENTS";
            OuvrirFormDansPanel(new AfficherClientForm());
        }

        private void btnCommandes_Click(object sender, EventArgs e)
        {
            ActiverBouton((Button)sender);
            lblTitle.Text = "📋 COMMANDES";
            OuvrirFormDansPanel(new AfficherCommandeForm());
        }

        private void btnPaiements_Click(object sender, EventArgs e)
        {
            ActiverBouton((Button)sender);
            lblTitle.Text = "💰 PAIEMENTS";
            OuvrirFormDansPanel(new AfficherPaiementForm());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActiverBouton((Button)sender);
            lblTitle.Text = "👤 UTILISATEURS";
            OuvrirFormDansPanel(new AfficherUserForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "🛠 PARAMÈTRES UTILISATEURS";
            ActiverBouton((Button)sender);
            OuvrirFormDansPanel(new ParametreForm());
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", 
                "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionUtilisateur.Deconnecter();
                
                // Retourner à l'écran de login
                Login loginForm = new Login();
                this.Close();
                loginForm.Show();
            }
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            CultureInfo francais = new CultureInfo("fr-FR");
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy\nhh:mm:ss tt", francais);
        }

        // Gestion des redimensionnements
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Assurer que le dashboard s'adapte à la taille
            if (activeForm != null && activeForm is DashboardForm dashboardForm)
            {
                dashboardForm.AdapterAuRedimensionnement();
            }
        }
    }
}