namespace Pos_Restaurant.Views.Commandes;

using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

public partial class AfficherCommandeForm : Form
{
    private CommandesController controller;

    public AfficherCommandeForm()
    {
        InitializeComponent();
        controller = new CommandesController();
        ChargerCommandes();
    }

    
    private void btnAjouter_Click(object sender, EventArgs e)
    {
        AjouterCommandeForm formAjout = new AjouterCommandeForm();
    
        // Définir le parent
        formAjout.Owner = this;
    
        // Ouvrir en modal
        formAjout.ShowDialog();
    
        // Recharger la liste après fermeture
        ChargerCommandes();
    }
    
    private void ChargerCommandes()
    {
        dgvCommandes.AutoGenerateColumns = false;
        dgvCommandes.DataSource = controller.ListerCommandes();
        
        Console.WriteLine($"il y a {controller.ListerCommandes().Count} commandes");
    }

    private void btnModifier_Click(object sender, EventArgs e)
    {
        if (dgvCommandes.CurrentRow != null)
        {
            CommandesModel commande = (CommandesModel)dgvCommandes.SelectedRows[0].DataBoundItem;

            using (ModifierCommandeForm formModif = new ModifierCommandeForm(commande))
            {
                formModif.Owner = this;
                formModif.ShowDialog();
                ChargerCommandes(); 
            }
        }
        else
        {
            MessageBox.Show("Veuillez sélectionner un menu à modifier.");
        }
    }
    
    private void btnSupprimer_Click(object sender, EventArgs e)
    {
        if (dgvCommandes.CurrentRow != null)
        {
            // 1. Récupérer l'ID 
            int commandeId = Convert.ToInt32(dgvCommandes.CurrentRow.Cells["txtId"].Value);
            // string nomMenu = dgvCommandes.CurrentRow.Cells["comboMenu"].Value?.ToString() ?? "ce client";
            // string nomClient = dgvCommandes.CurrentRow.Cells["comboClient"].Value?.ToString() ?? "";
    
            // 2. Demander confirmation
            DialogResult dialogResult = MessageBox.Show(
                $"Voulez-vous vraiment supprimer cette Commande de menu , pour le client  ?", 
                "Confirmation de suppression", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);
    
            if (dialogResult == DialogResult.Yes)
            {
                try 
                {
                    // 3. Appel au contrôleur 
                    controller.SupprimerCommande(commandeId);
                
                    MessageBox.Show("Commande supprimé avec succès !");
                    ChargerCommandes(); // Rafraîchir la grille
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
                }
            }
        }
        else
        {
            MessageBox.Show("Veuillez sélectionner un client dans la liste.");
        }
    }

    
}