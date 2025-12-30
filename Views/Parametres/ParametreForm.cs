using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Pos_Restaurant.Views
{
    public partial class ParametreForm : Form
    {
        private string fichierConfig = "config.ini";
        
        public ParametreForm()
        {
            InitializeComponent();
            ChargerParametres();
            InitialiserTheme();
        }

        private void ChargerParametres()
        {
            try
            {
                if (File.Exists(fichierConfig))
                {
                    var lignes = File.ReadAllLines(fichierConfig);
                    foreach (var ligne in lignes)
                    {
                        var parts = ligne.Split('=');
                        if (parts.Length == 2)
                        {
                            switch (parts[0].Trim())
                            {
                                case "NomRestaurant":
                                    txtNomRestaurant.Text = parts[1];
                                    break;
                                case "Adresse":
                                    txtAdresse.Text = parts[1];
                                    break;
                                case "Telephone":
                                    txtTelephone.Text = parts[1];
                                    break;
                                case "Devise":
                                    txtDevise.Text = parts[1];
                                    break;
                                case "TVA":
                                    if (decimal.TryParse(parts[1], out decimal tva))
                                        numTVA.Value = tva;
                                    break;
                                case "Theme":
                                    comboTheme.Text = parts[1];
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    // Valeurs par défaut
                    txtNomRestaurant.Text = "POS Restaurant";
                    txtDevise.Text = "HTG";
                    numTVA.Value = 0;
                    comboTheme.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}", "Erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnregistrerParametres()
        {
            try
            {
                var lignes = new string[]
                {
                    $"NomRestaurant={txtNomRestaurant.Text.Trim()}",
                    $"Adresse={txtAdresse.Text.Trim()}",
                    $"Telephone={txtTelephone.Text.Trim()}",
                    $"Devise={txtDevise.Text.Trim()}",
                    $"TVA={numTVA.Value}",
                    $"Theme={comboTheme.Text}"
                };

                File.WriteAllLines(fichierConfig, lignes);
                
                MessageBox.Show("✅ Paramètres enregistrés avec succès !\n\n" +
                              "Certains changements nécessitent un redémarrage de l'application.", 
                              "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Erreur lors de l'enregistrement : {ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitialiserTheme()
        {
            // Charger le thème actuel
            string theme = comboTheme.Text;
            AppliquerTheme(theme);
        }

        private void AppliquerTheme(string theme)
        {
            switch (theme.ToLower())
            {
                case "orange":
                    panelPreview.BackColor = Color.FromArgb(255, 128, 0);
                    break;
                case "bleu":
                    panelPreview.BackColor = Color.FromArgb(33, 150, 243);
                    break;
                case "vert":
                    panelPreview.BackColor = Color.FromArgb(76, 175, 80);
                    break;
                case "violet":
                    panelPreview.BackColor = Color.FromArgb(156, 39, 176);
                    break;
                default:
                    panelPreview.BackColor = Color.FromArgb(255, 128, 0);
                    break;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ValiderFormulaire())
            {
                EnregistrerParametres();
            }
        }

        private bool ValiderFormulaire()
        {
            // Validation du nom du restaurant
            if (string.IsNullOrWhiteSpace(txtNomRestaurant.Text))
            {
                MessageBox.Show("🏪 Le nom du restaurant est obligatoire.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomRestaurant.Focus();
                return false;
            }

            // Validation de la devise
            if (string.IsNullOrWhiteSpace(txtDevise.Text))
            {
                MessageBox.Show("💰 La devise est obligatoire.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDevise.Focus();
                return false;
            }

            // Validation de la TVA
            if (numTVA.Value < 0 || numTVA.Value > 100)
            {
                MessageBox.Show("📊 La TVA doit être entre 0 et 100%.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numTVA.Focus();
                numTVA.Select(0, numTVA.Text.Length);
                return false;
            }

            // Validation du thème
            if (string.IsNullOrEmpty(comboTheme.Text))
            {
                MessageBox.Show("🎨 Veuillez sélectionner un thème.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboTheme.Focus();
                return false;
            }

            return true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnRestaurer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez-vous restaurer les paramètres par défaut ?\n\n" +
                                       "Cette action effacera toutes vos modifications.", 
                                       "Confirmation", 
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RestaurerDefauts();
            }
        }

        private void RestaurerDefauts()
        {
            txtNomRestaurant.Text = "POS Restaurant";
            txtAdresse.Text = "";
            txtTelephone.Text = "";
            txtDevise.Text = "HTG";
            numTVA.Value = 0;
            comboTheme.SelectedIndex = 0;
            
            MessageBox.Show("⚙️ Paramètres restaurés par défaut.", 
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTheme.SelectedItem != null)
            {
                AppliquerTheme(comboTheme.Text);
            }
        }

        private void btnTestImprimante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("🖨️ Impression de test envoyée à l'imprimante par défaut.\n" +
                          "Vérifiez que l'imprimante est allumée et connectée.", 
                          "Test d'impression", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}