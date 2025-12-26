namespace Pos_Restaurant.Views.Clients;

using Pos_Restaurant.Models;
using Pos_Restaurant.Controllers;
public partial class AjouterClientForm : Form
{
    private ClientsController controller;
    public AjouterClientForm()
    {
        InitializeComponent();
        controller = new ClientsController();
    }
    
        
    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        try
        {
            
            // 2. Créer l'objet Model à partir des contrôles UI
            ClientsModel nouveauClient = new ClientsModel()
            {
            Nom = txtNom.Text,
            Prenom = txtPrenom.Text,
            Sexe = comboSexe.Text,
            Telephone = txtTelephone.Text,
            Email = txtEmail.Text,
            MontantDette = (double)txtMontantDette.Value
            };
            
            // 3. Afficher message d'attente
            AfficherMessage("⏳ Enregistrement en cours...", Color.Blue);
            Console.WriteLine("Enregistrement en cours...");
            this.Refresh(); 
            
            // 4. Appeler le contrôleur avec l'objet
            bool succes = controller.EnregistrerClient(nouveauClient);
            
            // 5. Gérer la réponse
            if (succes)
            {
               AfficherMessage($"Menu '{nouveauClient.Nom}' '{nouveauClient.Prenom}' enregistré avec succès!", 
                                Color.Green);
                ViderFormulaire();
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

    
    private void AfficherMessage(string message, Color color)
    {
        lblMessage.Text = message;
        lblMessage.ForeColor = color;
    }
    
    private void ViderFormulaire()
    {
        txtNom.Clear();
        txtPrenom.Clear();
        txtTelephone.Clear();
        txtEmail.Clear();
        txtMontantDette.Value = 0;
        comboSexe.SelectedIndex = -1;
        txtNom.Focus();
     
    }
    
    private void btnVider_Click(object sender, EventArgs e)
    {
        ViderFormulaire();
    }
}