namespace Pos_Restaurant.Views.Commandes;

using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

public partial class AjouterCommandeForm : Form
{
    private CommandesController controller;
    public AjouterCommandeForm()
    {
        controller = new CommandesController();
        InitializeComponent();
    }
    
    
     private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        try
        {
            
            // 2. Créer l'objet Model à partir des contrôles UI
            CommandesModel nouvelleCommande = new CommandesModel()
            { 
            // IdMenu  = (int)comboMenu.ValueMember,
            // IdClient = (int)comboClient.ValueMember,
            IdMenu  = 1,
            IdClient = 1,
            Quantite = (int)txtQuantite.Value,
            PrixTotal = (double)txtPrixTotal.Value,
            Description = txtDescription.Text,
            };
            
            // 3. Afficher message d'attente
            AfficherMessage("⏳ Enregistrement en cours...", Color.Blue);
            Console.WriteLine("Enregistrement en cours...");
            this.Refresh(); 
            
            // 4. Appeler le contrôleur avec l'objet
            bool succes = controller.EnregistrerCommande(nouvelleCommande);
            
            // 5. Gérer la réponse
            if (succes)
            {
                AfficherMessage($"Commande Menu'{nouvelleCommande.IdMenu}' pour '{nouvelleCommande.IdClient}' enregistré avec succès!", 
                                 Color.Green);
                // ViderFormulaire();
            }
            else
            {
              AfficherMessage("Échec de l'enregistrement", Color.Red);
            }
        }
        catch (FormatException)
        {
          AfficherMessage("Format de prix invalide", Color.Red);
        }
        catch (ArgumentException ex)
        {
          AfficherMessage($"Validation: {ex.Message}", Color.Orange);
        }
        catch (Exception ex)
        {
           AfficherMessage($"Erreur: {ex.Message}", Color.Red);
        }
    }

    
 
    
   
    
    private void btnVider_Click(object sender, EventArgs e)
    {
        // ViderFormulaire();
    }
    
    private void AfficherMessage(string message, Color color)
    {
        // lblMessage.Text = message;
        // lblMessage.ForeColor = color;
    }
        
    // private void ViderFormulaire()
    // {
    //     txtNom.Clear();
    //     txtPrix.Clear();
    //     txtDescription.Clear();
    //     txtQuantite.Value = 0;
    //     comboType.SelectedIndex = -1;
    //     txtNom.Focus();
    // }
}
