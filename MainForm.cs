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
using Pos_Restaurant.Dao;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

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
        
        private CommandesDao commandesDao;
        private CommandesController commandesController;
        private List<CommandesModel> commandes;

        public MainForm()
        {
            InitializeComponent();
            commandesDao = new CommandesDao();
            commandesController = new CommandesController();
            commandes = new List<CommandesModel>();
            cH = new CultureInfo("fr-HT"); 
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

            // Obtenir les statistiques
            var statistiques = ObtenirStatistiques();
            
            // Ajouter des cartes de statistiques
            statsPanel.Controls.Add(CreerCarteStatistique("💰", "Chiffre d'affaires total", 
                statistiques.ChiffreAffairesTotal.ToString("C2",cH), Color.FromArgb(76, 175, 80)));
            
            statsPanel.Controls.Add(CreerCarteStatistique("📈", "Qte Ventes Aujourd.", 
                statistiques.CommandesAujourdhui.ToString(), Color.FromArgb(33, 150, 243)));
            
            statsPanel.Controls.Add(CreerCarteStatistique("🏆", "Menu plus vendu", 
                statistiques.MenuPlusVendu, Color.FromArgb(255, 193, 7)));
            
            statsPanel.Controls.Add(CreerCarteStatistique("📊", "Rev. Aujourd.", 
                statistiques.RevenuAujourdhui.ToString("C2",cH), Color.FromArgb(156, 39, 176)));

            // Panneau pour les statistiques détaillées
            var detailsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(0, 220, 0, 0),
                Padding = new Padding(10)
            };

            // Tableau pour les statistiques par période
            var tableauPanel = CreerTableauStatistiques(statistiques);
            tableauPanel.Dock = DockStyle.Top;
            tableauPanel.Height = 180;

            // Graphique des ventes
            var chartPanel = CreerGraphiqueVentes(statistiques);
            chartPanel.Dock = DockStyle.Fill;
            chartPanel.Margin = new Padding(0, 190, 0, 0);

            detailsPanel.Controls.Add(tableauPanel);
            detailsPanel.Controls.Add(chartPanel);
            
            panel.Controls.Add(statsPanel);
            panel.Controls.Add(detailsPanel);
            
            OuvrirFormDansPanel(panel);
        }

        private StatistiquesDashboard ObtenirStatistiques()
        {
            var statistiques = new StatistiquesDashboard();
            
            try
            {
                // Obtenir toutes les commandes
                commandes = commandesController.ListerCommandes();
                
                if (commandes.Any())
                {
                    // 1. CHIFFRE D'AFFAIRES TOTAL
                    statistiques.ChiffreAffairesTotal = commandes.Sum(c => c.PrixTotal);
                    
                    // 2. NOMBRE DE COMMANDES AUJOURD'HUI
                    var aujourdhui = DateTime.Today;
                    
                    var commandesAujourdhui = commandes
                        .Where(c => c.DateCommande.Year == aujourdhui.Year && 
                                    c.DateCommande.Month == aujourdhui.Month && 
                                    c.DateCommande.Day == aujourdhui.Day)
                        .ToList();
                    
                    statistiques.CommandesAujourdhui = commandesAujourdhui.Sum(c => c.Quantite);
                    
                    // 3. MENU LE PLUS VENDU
                    if (commandesAujourdhui.Any())
                    {
                        // Menu le plus vendu AUJOURD'HUI
                        var menuStatsAujourdhui = commandesAujourdhui
                            .GroupBy(c => c.IdMenu)
                            .Select(g => new 
                            { 
                                MenuId = g.Key, 
                                TotalQuantite = g.Sum(x => x.Quantite),
                                NomMenu = g.FirstOrDefault()?.NomMenu ?? $"Menu #{g.Key}"
                            })
                            .OrderByDescending(x => x.TotalQuantite)
                            .FirstOrDefault();
                        
                        if (menuStatsAujourdhui != null)
                        {
                            statistiques.MenuPlusVendu = $"{menuStatsAujourdhui.NomMenu} ({menuStatsAujourdhui.TotalQuantite} unités)";
                        }
                    }
                    else
                    {
                        // Si pas de commandes aujourd'hui, menu le plus vendu global
                        var menuStatsGlobal = commandes
                            .GroupBy(c => c.IdMenu)
                            .Select(g => new 
                            { 
                                MenuId = g.Key, 
                                TotalQuantite = g.Sum(x => x.Quantite),
                                NomMenu = g.FirstOrDefault()?.NomMenu ?? $"Menu #{g.Key}"
                            })
                            .OrderByDescending(x => x.TotalQuantite)
                            .FirstOrDefault();
                        
                        if (menuStatsGlobal != null)
                        {
                            statistiques.MenuPlusVendu = $"{menuStatsGlobal.NomMenu} ({menuStatsGlobal.TotalQuantite} unités)";
                        }
                    }
                    
                    // 4. REVENU AUJOURD'HUI
                    if (commandesAujourdhui.Any())
                    {
                        statistiques.RevenuAujourdhui = commandesAujourdhui.Sum(c => c.PrixTotal);
                    }
                    else
                    {
                        statistiques.RevenuAujourdhui = 0;
                    }
                    
                    // Statistiques par période pour les graphiques
                    statistiques.StatistiquesParHeure = CalculerStatistiquesParHeure(commandesAujourdhui);
                    statistiques.StatistiquesParJour = CalculerStatistiquesParJour(commandes);
                    statistiques.StatistiquesParSemaine = CalculerStatistiquesParSemaine(commandes);
                }
                else
                {
                    // Aucune commande
                    statistiques.ChiffreAffairesTotal = 0;
                    statistiques.CommandesAujourdhui = 0;
                    statistiques.MenuPlusVendu = "Aucune vente";
                    statistiques.RevenuAujourdhui = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du calcul des statistiques: {ex.Message}");
                // Valeurs par défaut en cas d'erreur
                statistiques.ChiffreAffairesTotal = 0;
                statistiques.CommandesAujourdhui = 0;
                statistiques.MenuPlusVendu = "Erreur de calcul";
                statistiques.RevenuAujourdhui = 0;
            }
            
            return statistiques;
        }

        private Dictionary<int, double> CalculerStatistiquesParHeure(List<CommandesModel> commandes)
        {
            var stats = new Dictionary<int, double>();
            
            for (int heure = 0; heure <= 23; heure++) 
            {
                var ventes = 0.0;
                
                if (commandes != null && commandes.Any())
                {
                    ventes = commandes
                        .Where(c => c.DateCommande.Hour == heure)
                        .Sum(c => c.PrixTotal);
                }
                
                stats[heure] = ventes;
            }
            
            return stats;
        }

        private Dictionary<string, double> CalculerStatistiquesParJour(List<CommandesModel> commandes)
        {
            var stats = new Dictionary<string, double>();
            var jours = new[] { "Lun", "Mar", "Mer", "Jeu", "Ven", "Sam", "Dim" };
            
            for (int i = 0; i < 7; i++)
            {
                var ventes = commandes
                    .Where(c => (int)c.DateCommande.DayOfWeek == i)
                    .Sum(c => c.PrixTotal);
                
                stats[jours[i]] = ventes;
            }
            
            return stats;
        }

        private Dictionary<int, double> CalculerStatistiquesParSemaine(List<CommandesModel> commandes)
        {
            var stats = new Dictionary<int, double>();
            
            for (int semaine = 0; semaine < 4; semaine++)
            {
                var dateFin = DateTime.Today.AddDays(-(semaine * 7));
                var dateDebut = dateFin.AddDays(-6); 
                
                var ventes = commandes
                    .Where(c => c.DateCommande.Date >= dateDebut && c.DateCommande.Date <= dateFin)
                    .Sum(c => c.PrixTotal);
                
                stats[semaine] = ventes;
            }
            
            return stats;
        }

        private Panel CreerCarteStatistique(string icon, string title, string value, Color color)
        {
            var panel = new Panel
            {
                Size = new Size(220, 160),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15),
                Margin = new Padding(10)
            };

            // Arrondir les coins
            panel.Paint += (sender, e) =>
            {
                using (var path = RoundedRectangle(panel.ClientRectangle, 10))
                using (var brush = new SolidBrush(panel.BackColor))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(brush, path);
                    e.Graphics.DrawPath(new Pen(Color.LightGray, 1), path);
                }
            };

            var lblIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI Emoji", 16),
                Location = new Point(15, 15),
                AutoSize = true
            };

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(15, 60),
                AutoSize = true
            };

            var lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = color,
                Location = new Point(15, 85),
                AutoSize = true
            };

            panel.Controls.AddRange(new Control[] { lblIcon, lblTitle, lblValue });
            return panel;
        }

        private Panel CreerTableauStatistiques(StatistiquesDashboard stats)
        {
            var panel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10)
            };

            var lblTitre = new Label
            {
                Text = "📊 Statistiques par période",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            var tableau = new DataGridView
            {
                Location = new Point(10, 40),
                Size = new Size(panel.Width - 40, 130),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToOrderColumns = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Configurer les colonnes
            tableau.Columns.Add("Periode", "Période");
            tableau.Columns.Add("Ventes", "Ventes (HTG)");
            tableau.Columns.Add("Tendance", "Tendance");

            // Ajouter des données réelles
            tableau.Rows.Add("Aujourd'hui", 
                            stats.RevenuAujourdhui.ToString("C0"), 
                            stats.CommandesAujourdhui > 0 ? "📈" : "➖");
            
            // Cette semaine
            if (stats.StatistiquesParSemaine.TryGetValue(0, out var semaine0))
            {
                tableau.Rows.Add("Cette semaine", 
                                semaine0.ToString("C0"), 
                                semaine0 > 0 ? "📊" : "➖");
            }
            else
            {
                tableau.Rows.Add("Cette semaine", "0 HTG", "➖");
            }
            
            double revenuMois = stats.StatistiquesParSemaine.Values.Sum();
            tableau.Rows.Add("Ce mois", 
                            revenuMois.ToString("C0"), 
                            revenuMois > 0 ? "📈" : "➖");
            
            if (stats.StatistiquesParHeure != null && stats.StatistiquesParHeure.Any())
            {
                var topHeure = stats.StatistiquesParHeure
                    .OrderByDescending(x => x.Value)
                    .FirstOrDefault();
                
                if (topHeure.Value > 0)
                {
                    tableau.Rows.Add($"Top heure ({topHeure.Key}h)", 
                                    topHeure.Value.ToString("C0"), 
                                    "⏰");
                }
            }

            panel.Controls.Add(lblTitre);
            panel.Controls.Add(tableau);
            
            return panel;
        }

        private Panel CreerGraphiqueVentes(StatistiquesDashboard stats)
        {
            var panel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10)
            };

            var lblTitre = new Label
            {
                Text = "📈 Évolution des ventes",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            var lblSousTitre = new Label
            {
                Text = "Ventes par jour de semaine (moyenne)",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(10, 35),
                AutoSize = true
            };

            var graphiquePanel = new Panel
            {
                Location = new Point(10, 60),
                Size = new Size(panel.Width - 40, 150),
                BackColor = Color.WhiteSmoke
            };

            graphiquePanel.Paint += (sender, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                
                // Dessiner les axes
                g.DrawLine(Pens.Black, 40, 20, 40, graphiquePanel.Height - 30);
                g.DrawLine(Pens.Black, 40, graphiquePanel.Height - 30, graphiquePanel.Width - 10, graphiquePanel.Height - 30);
                
                // Dessiner les barres basées sur les statistiques réelles
                var jours = new[] { "Lun", "Mar", "Mer", "Jeu", "Ven", "Sam", "Dim" };
                var largeurBarre = 30;
                var espace = 15;
                var hauteurMax = graphiquePanel.Height - 60; // Hauteur maximale pour les barres
                
                // Trouver la valeur maximale pour l'échelle
                double maxValeur = 1;
                if (stats.StatistiquesParJour != null && stats.StatistiquesParJour.Any())
                {
                    maxValeur = Math.Max(stats.StatistiquesParJour.Values.Max(), 1);
                }
                
                for (int i = 0; i < 7; i++)
                {
                    var x = 60 + i * (largeurBarre + espace);
                    
                    // Obtenir la valeur pour ce jour
                    double valeurJour = 0;
                    if (stats.StatistiquesParJour != null && stats.StatistiquesParJour.ContainsKey(jours[i]))
                    {
                        valeurJour = stats.StatistiquesParJour[jours[i]];
                    }
                    
                    // Calculer la hauteur proportionnelle
                    var hauteur = (int)((valeurJour / maxValeur) * hauteurMax);
                    if (hauteur < 5) hauteur = 5; // Hauteur minimale
                    
                    // Barre
                    g.FillRectangle(Brushes.RoyalBlue, x, graphiquePanel.Height - 30 - hauteur, largeurBarre, hauteur);
                    
                    // Valeur
                    if (valeurJour > 0)
                    {
                        g.DrawString(valeurJour.ToString("C0"), new Font("Segoe UI", 7), Brushes.Black, 
                            x, graphiquePanel.Height - 30 - hauteur - 15);
                    }
                    
                    // Jour
                    g.DrawString(jours[i], new Font("Segoe UI", 8), Brushes.Black, 
                        x + largeurBarre/2 - 10, graphiquePanel.Height - 25);
                }
            };

            panel.Controls.Add(lblTitre);
            panel.Controls.Add(lblSousTitre);
            panel.Controls.Add(graphiquePanel);
            
            return panel;
        }

        private GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Coin supérieur gauche
            path.AddArc(arc, 180, 90);

            // Coin supérieur droit
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Coin inférieur droit
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Coin inférieur gauche
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
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

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            CultureInfo francais = new CultureInfo("fr-FR");
            
            
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy\nhh:mm:ss tt", francais);
        }
    }

    // Classe pour stocker les statistiques
    public class StatistiquesDashboard
    {
        // 4 statistiques principales
        public double ChiffreAffairesTotal { get; set; }
        public int CommandesAujourdhui { get; set; }
        public string MenuPlusVendu { get; set; } = "N/A";
        public double RevenuAujourdhui { get; set; }
    
        // Statistiques supplémentaires pour graphiques
        public Dictionary<int, double> StatistiquesParHeure { get; set; } = new Dictionary<int, double>();
        public Dictionary<string, double> StatistiquesParJour { get; set; } = new Dictionary<string, double>();
        public Dictionary<int, double> StatistiquesParSemaine { get; set; } = new Dictionary<int, double>();
    }
}