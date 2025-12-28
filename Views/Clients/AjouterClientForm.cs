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
            if (!ValiderSaisieClient())
            {
                return;
            }
            
            // 2. Créer l'objet Model à partir des contrôles UI
            ClientsModel nouveauClient = new ClientsModel()
            {
            Nom = txtNom.Text,
            Prenom = txtPrenom.Text,
            Sexe = comboSexe.Text,
            Telephone = "+509 "+txtTelephone.Text,
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
    
    private bool ValiderSaisieClient()
    {
        // 1. Vérification des champs vides
        if (string.IsNullOrWhiteSpace(txtNom.Text) || 
            string.IsNullOrWhiteSpace(txtPrenom.Text) || 
            string.IsNullOrWhiteSpace(comboSexe.Text))
        {
            MessageBox.Show("Le nom, le prénom et le sexe sont obligatoires.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // 2. Validation du téléphone (format standard : au moins 8 chiffres)
        if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelephone.Text.Substring(5), @"^[3-5][0-9]{7}$"))
        {
            MessageBox.Show("Le numéro est invalide (8 chiffres attendus comm par 3, 4 ou 5).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // 3. Validation de l'Email
        try {
            var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
            if (addr.Address != txtEmail.Text) throw new Exception();
        }
        catch {
            MessageBox.Show("L'adresse email n'est pas valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true; 
    }
}