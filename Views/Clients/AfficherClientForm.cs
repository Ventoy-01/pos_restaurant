namespace Pos_Restaurant.Views.Clients;

using Pos_Restaurant.Controllers;

public partial class AfficherClientForm : Form
{
    private ClientsController controller;

    public AfficherClientForm()
    {
        InitializeComponent();
        controller = new ClientsController();
        ChargerClients();
    }

    
    private void btnAjouter_Click(object sender, EventArgs e)
    {
        AjouterClientForm formAjout = new AjouterClientForm();
    
        // Définir le parent
        formAjout.Owner = this;

        // Ouvrir en modal
        formAjout.ShowDialog();

        // Recharger la liste après fermeture
        ChargerClients();
    }
    
    private void ChargerClients()
    {
        dgvClients.AutoGenerateColumns = false;
        dgvClients.DataSource = controller.ListerClients();
        
        Console.WriteLine($"il y a {controller.ListerClients().Count} clients");
    }


    private void btnSupprimer_Click(object sender, EventArgs e)
    {
        if (dgvClients.CurrentRow != null)
        {
            // 1. Récupérer l'ID 
            int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells["txtId"].Value);
            string nomClient = dgvClients.CurrentRow.Cells["txtNom"].Value?.ToString() ?? "ce client";
            string prClient = dgvClients.CurrentRow.Cells["txtPrenom"].Value?.ToString() ?? "";

            // 2. Demander confirmation
            DialogResult dialogResult = MessageBox.Show(
                $"Voulez-vous vraiment supprimer {nomClient} {prClient} ?", 
                "Confirmation de suppression", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try 
                {
                    // 3. Appel au contrôleur 
                    controller.SupprimerClient(clientId);
                
                    MessageBox.Show("Client supprimé avec succès !");
                    ChargerClients(); // Rafraîchir la grille
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