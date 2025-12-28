namespace Pos_Restaurant.Views.Commandes;

using Pos_Restaurant.Controllers;

public partial class AfficherCommandeForm : Form
{
    private CommandesController controller;

    public AfficherCommandeForm()
    {
        InitializeComponent();
        controller = new CommandesController();
        // ChargerCommandes();
    }

    
    private void btnAjouter_Click(object sender, EventArgs e)
    {
        AjouterCommandeForm formAjout = new AjouterCommandeForm();
    
        // Définir le parent
        formAjout.Owner = this;
    
        // Ouvrir en modal
        formAjout.ShowDialog();
    
        // Recharger la liste après fermeture
        // ChargerCommandes();
    }
    
    // private void ChargerCommandes()
    // {
    //     dgvCommandes.AutoGenerateColumns = false;
    //     dgvCommandes.DataSource = controller.ListerCommandes();
    //     
    //     Console.WriteLine($"il y a {controller.ListerCommandes().Count} clients");
    // }


    // private void btnSupprimer_Click(object sender, EventArgs e)
    // {
    //     if (dgvCommandes.CurrentRow != null)
    //     {
    //         // 1. Récupérer l'ID 
    //         int clientId = Convert.ToInt32(dgvCommandes.CurrentRow.Cells["txtId"].Value);
    //         string nomClient = dgvCommandes.CurrentRow.Cells["txtNom"].Value?.ToString() ?? "ce client";
    //         string prClient = dgvCommandes.CurrentRow.Cells["txtPrenom"].Value?.ToString() ?? "";
    //
    //         // 2. Demander confirmation
    //         DialogResult dialogResult = MessageBox.Show(
    //             $"Voulez-vous vraiment supprimer {nomClient} {prClient} ?", 
    //             "Confirmation de suppression", 
    //             MessageBoxButtons.YesNo, 
    //             MessageBoxIcon.Warning);
    //
    //         if (dialogResult == DialogResult.Yes)
    //         {
    //             try 
    //             {
    //                 // 3. Appel au contrôleur 
    //                 controller.SupprimerCommande(clientId);
    //             
    //                 MessageBox.Show("Client supprimé avec succès !");
    //                 ChargerClients(); // Rafraîchir la grille
    //             }
    //             catch (Exception ex)
    //             {
    //                 MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
    //             }
    //         }
    //     }
    //     else
    //     {
    //         MessageBox.Show("Veuillez sélectionner un client dans la liste.");
    //     }
    // }

    
}