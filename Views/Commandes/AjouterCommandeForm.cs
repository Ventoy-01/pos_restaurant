using Pos_Restaurant.Dao;
namespace Pos_Restaurant.Views.Commandes;

using Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

public partial class AjouterCommandeForm : Form
{
    private CommandesController controller;
    private MenusDao menusDao;
    private ClientsDao clientsDao;

    private List<MenusModel> menus;
    private List<ClientsModel> clients;
    
    MenusModel menu = new MenusModel();
    
    public AjouterCommandeForm()
    {
        InitializeComponent();

        txtPrixTotal.Maximum = decimal.MaxValue;
       
        txtPrixTotal.Enabled = false;
        
        controller = new CommandesController();
        menusDao = new MenusDao();
        clientsDao = new ClientsDao(); // <-- Important : initialiser le Dao client
            
        comboMenu.SelectedIndexChanged += (s, e) => CalculerPrixTotal();
        comboMenu.SelectedIndexChanged += (s, e) => calculerQuantite_Max();
        
        txtQuantite.ValueChanged += (s, e) => CalculerPrixTotal();
        menus = new List<MenusModel>();
        clients = new List<ClientsModel>();
        
        InitialiserCommande();
      
    }

    private void InitialiserCommande()
    {
        try
        {
            // Charger les données
            clients = clientsDao.Lister();
            menus = menusDao.Lister();
            
            // Vider les combos
            comboClient.Items.Clear();
            comboMenu.Items.Clear();
            
            // Remplir la liste des clients
            foreach (var client in clients)
            {
                comboClient.Items.Add($"{client.Id} - {client.Nom} {client.Prenom}");
            }
            
            // Remplir la liste des menus
            foreach (var menu in menus)
            {
                comboMenu.Items.Add($"{menu.Id} - {menu.Nom} ");
            }
            
            // Initialiser les prix
            // txtPrixT.Value = 0;
            txtPrixTotal.Value = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", 
                          "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    // Événement lors de la sélection d'un menu
    
    private void calculerQuantite_Max( )
    {   
        // Extraire l'ID du menu sélectionné
        string selectedText = comboMenu.SelectedItem.ToString();
        string idPart = selectedText.Split('-')[0].Trim();
        // string selectedText = comboMenu.SelectedItem.ToString();
        if (int.TryParse(idPart, out int menuId))
        {
            // Trouver le menu pour récupérer son prix
            var menu = menus.FirstOrDefault(m => m.Id == menuId);
            if (menu != null)
            {
                txtQuantite.Maximum = menu.Quantite;
            }
        }
    }
    
    // Événement lors du changement de quantité
    // private void txtQuantite_ValueChanged(object sender, EventArgs e)
    // {
    //     CalculerPrixTotal();
    // }
    
  
    private void CalculerPrixTotal()
    {
        if (comboMenu.SelectedIndex >= 0 && txtQuantite.Value > 0)
        {
            try
            {
                // Extraire l'ID du menu sélectionné
                string selectedText = comboMenu.SelectedItem.ToString();
                string idPart = selectedText.Split('-')[0].Trim();
                
                if (int.TryParse(idPart, out int menuId))
                {
                    // Trouver le menu pour récupérer son prix
                    var menu = menus.FirstOrDefault(m => m.Id == menuId);
                    if (menu != null)
                    {
                        // double txtPrixUnitaire;
                        // txtPrixUnitaire.Value = (decimal)menu.PrixUnitaire;
                        decimal prixTotal = (decimal)menu.PrixUnitaire * txtQuantite.Value;
                        txtPrixTotal.Value = prixTotal;
                        // this.prixTotal = prixTotal;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur de calcul: {ex.Message}");
            }
        }
    }
    
    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        try
        {
            // Validation des champs obligatoires
            if (comboMenu.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner un menu", 
                              "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboMenu.Focus();
                return;
            }
            
            if (comboClient.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner un client", 
                              "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboClient.Focus();
                return;
            }
            
            if (txtQuantite.Value <= 0)
            {
                MessageBox.Show("La quantité doit être supérieure à 0", 
                              "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantite.Focus();
                return;
            }
            
            // Extraire les IDs
            int idMenu = ExtraireIdSelection(comboMenu);
            int idClient = ExtraireIdSelection(comboClient);
            
            // Trouver le menu pour récupérer le prix unitaire
            var menuSelectionne = menus.FirstOrDefault(m => m.Id == idMenu);
            if (menuSelectionne == null)
            {
                MessageBox.Show("Menu non trouvé", 
                              "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Calculer le prix total (au cas où l'utilisateur aurait modifié manuellement)
            double prixTotal = (double)menuSelectionne.PrixUnitaire * (int)txtQuantite.Value;
            
            // 2. Créer l'objet Model à partir des contrôles UI
            CommandesModel nouvelleCommande = new CommandesModel()
            { 
                IdMenu = idMenu,
                IdClient = idClient,
                Quantite = (int)txtQuantite.Value,
                PrixTotal = prixTotal, // Utiliser le prix calculé
                Description = txtDescription.Text
            };
            
            // 3. Afficher message d'attente
            AfficherMessage("⏳ Enregistrement en cours...", Color.Blue);
            this.Refresh(); 
            
            // 4. Appeler le contrôleur avec l'objet
            bool succes = controller.EnregistrerCommande(nouvelleCommande);
            
            // 5. Gérer la réponse
            if (succes)
            {
                AfficherMessage($"Commande enregistrée avec succès!", Color.Green);
                
                // Fermer le formulaire après succès
                DialogResult = DialogResult.OK;
                this.Close();
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

    private int ExtraireIdSelection(ComboBox combo)
    {
        if (combo.SelectedItem != null)
        {
            string texte = combo.SelectedItem.ToString();
            if (texte.Contains("-"))
            {
                string idPart = texte.Split('-')[0].Trim();
                if (int.TryParse(idPart, out int id))
                    return id;
            }
        }
        throw new ArgumentException("Sélection invalide");
    }
    
    private void btnVider_Click(object sender, EventArgs e)
    {
        ViderFormulaire();
    }
    
    private void AfficherMessage(string message, Color color)
    {
        lblMessage.Text = message;
        lblMessage.ForeColor = color;
    }
        
    private void ViderFormulaire()
    {
        comboMenu.SelectedIndex = -1;
        comboClient.SelectedIndex = -1;
        txtQuantite.Value = 1;
        txtDescription.Clear();
        txtPrixTotal.Value = 0;
        comboMenu.Focus();
    }
    
    private void btnAnnuler_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}