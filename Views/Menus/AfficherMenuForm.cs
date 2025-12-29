namespace Pos_Restaurant.Views.Menus;

using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

public partial class AfficherMenuForm : Form
{
    private MenusController controller;
    
    public AfficherMenuForm()
    {
        InitializeComponent();
        controller = new MenusController();
        ChargerMenus();
        
    }
    
    private void ChargerMenus()
    {
        dgvMenus.AutoGenerateColumns = false;
        dgvMenus.DataSource = controller.ListerMenus();
        
       Console.WriteLine($"il y a {controller.ListerMenus().Count} menus");
    }
    
    private void txtRechercher_TextChanged(object sender, EventArgs e)
    {
        string critere = txtRechercher.Text.Trim();
    
        if (string.IsNullOrWhiteSpace(critere))
        {
            ChargerMenus();
            lblNombreResultats.Text = "";
            return;
        }

        try
        {
            var menus = controller.ListerMenus()
                .Where(m => 
                    (m.Id.ToString() ?? "").Contains(critere) ||
                    (m.PrixUnitaire.ToString() ?? "").Contains(critere) ||
                    (m.Quantite.ToString() ?? "").Contains(critere) ||
                    (m.Nom ?? "").Contains(critere, StringComparison.OrdinalIgnoreCase) ||
                    (m.Type ?? "").Contains(critere, StringComparison.OrdinalIgnoreCase) ||
                    (m.Description ?? "").Contains(critere, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvMenus.DataSource = menus;
            
            // Afficher le nombre de résultats
            lblNombreResultats.Text = $"{menus.Count} menu(s) trouvé(s)";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur lors de la recherche : {ex.Message}", "Erreur", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAjouter_Click(object sender, EventArgs e)
    {
        AjouterMenuForm formAjout = new AjouterMenuForm();
    
        // Définir le parent
        formAjout.Owner = this;

        // Ouvrir en modal
        formAjout.ShowDialog();

        // Recharger la liste après fermeture
        ChargerMenus();
    }
    
    private void btnModifier_Click(object sender, EventArgs e)
    {
        if (dgvMenus.CurrentRow != null)
        {
            MenusModel menu = (MenusModel)dgvMenus.SelectedRows[0].DataBoundItem;

            using (ModifierMenuForm formModif = new ModifierMenuForm(menu))
            {
                formModif.Owner = this;
                formModif.ShowDialog();
                ChargerMenus(); 
            }
        }
        else
        {
            MessageBox.Show("Veuillez sélectionner un menu à modifier.");
        }
    }
    
    
    private void btnSupprimer_Click(object sender, EventArgs e)
    {
        if (dgvMenus.CurrentRow != null)
        {
            // 1. Récupérer l'ID 
            int menuId = Convert.ToInt32(dgvMenus.CurrentRow.Cells["txtId"].Value);
            string nomMenu = dgvMenus.CurrentRow.Cells["txtNom"].Value?.ToString() ?? "ce menu";

            // 2. Demander confirmation
            DialogResult dialogResult = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le menu '{nomMenu}' ?", 
                "Confirmation de suppression", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try 
                {
                    bool succes = controller.supprimerMenu(menuId);
                    if (succes)
                    {
                        ChargerMenus();
                    }
                    else
                    {
                        MessageBox.Show("Échec de la suppression");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression: {ex.Message}");
                }
            }
        }
    }

}