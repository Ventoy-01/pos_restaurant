namespace Pos_Restaurant.Views.Users;

using System;
using System.Linq;
using System.Windows.Forms;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;


    public partial class AfficherUserForm : Form
    {
        private UsersController controller;

        public AfficherUserForm()
        {
            InitializeComponent();
            controller = new UsersController();
            ChargerUtilisateurs();
        }

        private void ChargerUtilisateurs()
        {
            try
            {
                var utilisateurs = controller.ListerUsers();
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.DataSource = utilisateurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}", "Erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            string critere = txtRechercher.Text.Trim();

            if (string.IsNullOrWhiteSpace(critere))
            {
                ChargerUtilisateurs();
                lblNombreResultats.Text = "";
                return;
            }

            try
            {
                var utilisateurs = controller.ListerUsers()
                    .Where(u => 
                        (u.Id.ToString()?? "").Contains(critere) ||
                        (u.Username ?? "").Contains(critere, StringComparison.OrdinalIgnoreCase) ||
                        (u.Role ?? "").Contains(critere, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                dgvUsers.DataSource = utilisateurs;
                lblNombreResultats.Text = $"{utilisateurs.Count} utilisateur(s) trouvé(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}", "Erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterUserForm formAjout = new AjouterUserForm();
            
           // Définir le parent
            formAjout.Owner = this;

            // Ouvrir en modal
            formAjout.ShowDialog();
            ChargerUtilisateurs();
                    
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.", 
                    "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsersModel user =(UsersModel) dgvUsers.SelectedRows[0].DataBoundItem;
           

            using (var formModif = new ModifierUserForm(user))
            {
                // Définir le parent
                formModif.Owner = this;

                // Ouvrir en modal
                formModif.ShowDialog();
                ChargerUtilisateurs();
                
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.", 
                    "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvUsers.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
            string username = selectedRow.Cells["colUsername"].Value?.ToString() ?? "Inconnu";

            var result = MessageBox.Show(
                $"Voulez-vous vraiment supprimer l'utilisateur '{username}' ?\n\n" +
                "⚠️ Cette action est irréversible !", 
                "Confirmation de suppression", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = controller.SupprimerUser(userId.ToString());
                    
                    if (success)
                    {
                        MessageBox.Show("Utilisateur supprimé avec succès.", "Succès", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChargerUtilisateurs();
                    }
                    else
                    {
                        MessageBox.Show("Échec de la suppression.", "Erreur", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Vérifie si nous sommes sur la colonne Password
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colPassword" && e.Value != null)
            {
                e.Value = new string('●', 8);
                e.FormattingApplied = true; 
            }
        }

    }
