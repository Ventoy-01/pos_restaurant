using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Pos_Restaurant.Views;
using Pos_Restaurant.Views.Clients;
using Pos_Restaurant.Views.Commandes;
using Pos_Restaurant.Views.Menus;
using Pos_Restaurant.Views.Paiements;
using Pos_Restaurant.Views.Users;

namespace Pos_Restaurant
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        private Button activeButton = null;
        private Color activeColor = Color.FromArgb(255, 128, 0);
        private Color normalColor = Color.FromArgb(64, 64, 64);
        private Color hoverColor = Color.FromArgb(100, 100, 100);

        public MainForm()
        {
            InitializeComponent();
            InitialiserDashboard();
            AfficherInfosUtilisateur();
        }

        private void InitialiserDashboard()
        {
            // Initialiser les couleurs
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
                
                // Icône selon le rôle
                string icon = "👤";
                lblUserIcon.Text = icon;
            }
            else
            {
                lblUserName.Text = "Non connecté";
                lblUserRole.Text = "Invité";
                lblUserIcon.Text = "👤";
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
            lblTitle.Text = "📊 DASHBOARD";
            
            // Créer un panneau de dashboard
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            // Créer des cartes de statistiques
            var statsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 200,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoScroll = true
            };

            // Ajouter des cartes de statistiques
            statsPanel.Controls.Add(CreerCarteStatistique("💰", "Chiffre d'affaires", "25,450 HTG", Color.FromArgb(76, 175, 80)));
            statsPanel.Controls.Add(CreerCarteStatistique("👥", "Clients", "154", Color.FromArgb(33, 150, 243)));
            statsPanel.Controls.Add(CreerCarteStatistique("🍽️", "Commandes", "42", Color.FromArgb(255, 193, 7)));
            statsPanel.Controls.Add(CreerCarteStatistique("📈", "Couverture", "87%", Color.FromArgb(156, 39, 176)));

            // Graphique (simplifié)
            var chartPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(0, 160, 0, 0)
            };

            var lblChartTitle = new Label
            {
                Text = "📈 Activité récente",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(20, 20),
                AutoSize = true
            };

            chartPanel.Controls.Add(lblChartTitle);

            panel.Controls.Add(statsPanel);
            panel.Controls.Add(chartPanel);
            
            OuvrirFormDansPanel(panel);
        }

        private Panel CreerCarteStatistique(string icon, string title, string value, Color color)
        {
            var panel = new FlowLayoutPanel // Changement ici
            {
                Size = new Size(200, 180), // Augmenté un peu pour la sécurité
                BackColor = Color.White,
                FlowDirection = FlowDirection.TopDown, // Aligne de haut en bas
                WrapContents = false,
                Padding = new Padding(15),
                Margin = new Padding(10)
            };

            // Gardez votre code de coin arrondi (panel.Paint += ...) ici

            var lblIcon = new Label {
                Text = icon,
                Font = new Font("Segoe UI Emoji", 20),
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 5) // Marge basse pour l'espace
            };

            var lblTitle = new Label {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Gray,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 2)
            };

            var lblValue = new Label {
                Text = value,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = color,
                AutoSize = true
            };

            panel.Controls.AddRange(new Control[] { lblIcon, lblTitle, lblValue });
            return panel;
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

        private void OuvrirFormDansPanel(Control control)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
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

        private void panelUserInfo_Click(object sender, EventArgs e)
        {
            // Afficher les infos détaillées de l'utilisateur
            MessageBox.Show($"Utilisateur : {lblUserName.Text}\nRôle : {lblUserRole.Text}", 
                "Informations utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy\nHH:mm:ss");
        }
    }
}