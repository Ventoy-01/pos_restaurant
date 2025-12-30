using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;
using System.Globalization;

namespace Pos_Restaurant
{
    public partial class DashboardForm : Form
    {
        private CommandesController commandesController;
        private List<CommandesModel> commandes;
        private CultureInfo cH;
        
        // Panneaux pour les contrôles
        private FlowLayoutPanel statsPanel;
        private Panel detailsPanel;
        private Panel tableauPanel;
        private Panel chartPanel;

        public DashboardForm()
        {
            InitializeComponent();
            InitializeDashboardComponents();
            commandesController = new CommandesController();
            commandes = new List<CommandesModel>();
            cH = new CultureInfo("fr-HT");
            
            // Charger les données
            ChargerDashboard();
        }

        private void InitializeDashboardComponents()
        {
            this.BackColor = Color.White;
            this.Padding = new Padding(20);
            
            // Panel pour les statistiques en haut
            statsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 200,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoScroll = true,
                BackColor = Color.Transparent
            };

            // Panel pour les détails
            detailsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(0, 220, 0, 0),
                Padding = new Padding(10)
            };

            this.Controls.Add(detailsPanel);
            this.Controls.Add(statsPanel);
        }

        private void ChargerDashboard()
        {
            var statistiques = ObtenirStatistiques();
            AfficherStatistiques(statistiques);
            AfficherDetails(statistiques);
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
                        .Where(c => c.DateCommande.Date == aujourdhui)
                        .ToList();
                    
                    statistiques.CommandesAujourdhui = commandesAujourdhui.Sum(c => c.Quantite);
                    
                    // 3. MENU LE PLUS VENDU
                    if (commandesAujourdhui.Any())
                    {
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
                    statistiques.RevenuAujourdhui = commandesAujourdhui.Sum(c => c.PrixTotal);
                    
                    // Statistiques supplémentaires
                    statistiques.StatistiquesParHeure = CalculerStatistiquesParHeure(commandesAujourdhui);
                    statistiques.StatistiquesParJour = CalculerStatistiquesParJour(commandes);
                    statistiques.StatistiquesParSemaine = CalculerStatistiquesParSemaine(commandes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du calcul des statistiques: {ex.Message}");
                // Valeurs par défaut
                statistiques.ChiffreAffairesTotal = 0;
                statistiques.CommandesAujourdhui = 0;
                statistiques.MenuPlusVendu = "Aucune vente";
                statistiques.RevenuAujourdhui = 0;
            }
            
            return statistiques;
        }

        private void AfficherStatistiques(StatistiquesDashboard stats)
        {
            statsPanel.Controls.Clear();
            
            // Ajouter les cartes de statistiques
            statsPanel.Controls.Add(CreerCarteStatistique("💰", "Chiffre d'affaires total", 
                stats.ChiffreAffairesTotal.ToString("C2", cH), Color.FromArgb(76, 175, 80)));
            
            statsPanel.Controls.Add(CreerCarteStatistique("📈", "Qte Ventes Aujourd.", 
                stats.CommandesAujourdhui.ToString(), Color.FromArgb(33, 150, 243)));
            
            statsPanel.Controls.Add(CreerCarteStatistique("🏆", "Menu plus vendu", 
                stats.MenuPlusVendu, Color.FromArgb(255, 193, 7)));
            
            statsPanel.Controls.Add(CreerCarteStatistique("📊", "Rev. Aujourd.", 
                stats.RevenuAujourdhui.ToString("C2", cH), Color.FromArgb(156, 39, 176)));
        }

        private void AfficherDetails(StatistiquesDashboard stats)
        {
            detailsPanel.Controls.Clear();
            
            // Tableau des statistiques
            tableauPanel = CreerTableauStatistiques(stats);
            tableauPanel.Dock = DockStyle.Top;
            tableauPanel.Height = 200;
            
            detailsPanel.Controls.Add(tableauPanel);
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
                Size = new Size(600, 170),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToOrderColumns = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                EnableHeadersVisualStyles = false 
            };

            tableau.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            tableau.MultiSelect = false;
            tableau.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            tableau.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tableau.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold); // Optionnel : pour un look plus moderne

            tableau.Columns.Add("Periode", "Période");
            tableau.Columns.Add("Ventes", "Ventes (HTG)");
            tableau.Columns.Add("Tendance", "Tendance");

            tableau.Rows.Add("Aujourd'hui", 
                            stats.RevenuAujourdhui.ToString("C0", cH), 
                            stats.CommandesAujourdhui > 0 ? "📈" : "➖");
            
            if (stats.StatistiquesParSemaine.TryGetValue(0, out var semaine0))
            {
                tableau.Rows.Add("Cette semaine", 
                                semaine0.ToString("C0", cH), 
                                semaine0 > 0 ? "📊" : "➖");
            }
            
            double revenuMois = stats.StatistiquesParSemaine.Values.Sum();
            tableau.Rows.Add("Ce mois", 
                            revenuMois.ToString("C0", cH), 
                            revenuMois > 0 ? "📈" : "➖");
            
            if (stats.StatistiquesParHeure.Any())
            {
                var topHeure = stats.StatistiquesParHeure
                    .OrderByDescending(x => x.Value)
                    .FirstOrDefault();
                
                if (topHeure.Value > 0)
                {
                    tableau.Rows.Add($"Top heure ({topHeure.Key}h)", 
                                    topHeure.Value.ToString("C0", cH), 
                                    "⏰");
                }
            }

            panel.Controls.Add(lblTitre);
            panel.Controls.Add(tableau);
            
            return panel;
        }

        // Méthodes de calcul des statistiques 
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

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public void AdapterAuRedimensionnement()
        {
            if (tableauPanel != null)
            {
                tableauPanel.Width = this.Width - 40;
            }
            
            if (chartPanel != null)
            {
                chartPanel.Width = this.Width - 40;
            }
        }

        // Méthode pour rafraîchir le dashboard
        public void Rafraichir()
        {
            ChargerDashboard();
        }
    }

    // Classe pour stocker les statistiques (à placer dans un fichier séparé si nécessaire)
    // public class StatistiquesDashboard
    // {
    //     public double ChiffreAffairesTotal { get; set; }
    //     public int CommandesAujourdhui { get; set; }
    //     public string MenuPlusVendu { get; set; } = "N/A";
    //     public double RevenuAujourdhui { get; set; }
    //     public Dictionary<int, double> StatistiquesParHeure { get; set; } = new Dictionary<int, double>();
    //     public Dictionary<string, double> StatistiquesParJour { get; set; } = new Dictionary<string, double>();
    //     public Dictionary<int, double> StatistiquesParSemaine { get; set; } = new Dictionary<int, double>();
    // }
}