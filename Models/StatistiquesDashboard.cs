namespace Pos_Restaurant.Models;


    public class StatistiquesDashboard
    {
        public double ChiffreAffairesTotal { get; set; }
        public int CommandesAujourdhui { get; set; }
        public string MenuPlusVendu { get; set; } = "N/A";
        public double RevenuAujourdhui { get; set; }
        public Dictionary<int, double> StatistiquesParHeure { get; set; } = new Dictionary<int, double>();
        public Dictionary<string, double> StatistiquesParJour { get; set; } = new Dictionary<string, double>();
        public Dictionary<int, double> StatistiquesParSemaine { get; set; } = new Dictionary<int, double>();
    }
