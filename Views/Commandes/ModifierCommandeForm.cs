namespace Pos_Restaurant.Views.Commandes;

using Pos_Restaurant.Models;
using Pos_Restaurant.Controllers;
using Pos_Restaurant.Dao;

public partial class ModifierCommandeForm : Form
{
    private CommandesModel commandeCourante;
    private CommandesController controller;
    private MenusDao menusDao;
    private ClientsDao clientsDao;

    // Déclarez ces listes comme champs de classe
    private List<MenusModel> menus;
    private List<ClientsModel> clients;
    
    public ModifierCommandeForm(CommandesModel commande)
    {
        InitializeComponent();
        
        controller = new CommandesController();
        commandeCourante = commande; 

        menusDao = new MenusDao();
        clientsDao = new ClientsDao();
        
        // Initialiser les listes
        menus = new List<MenusModel>();
        clients = new List<ClientsModel>();
        
        InitialiserCommande();
        ChargerCommandeDansFormulaire();
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
            foreach (var c in clients)
            {
                comboClient.Items.Add($"{c.Id} - {c.Nom} {c.Prenom}");
            }
            
            // Remplir la liste des menus
            foreach (var m in menus)
            {
                comboMenu.Items.Add($"{m.Id} - {m.Nom}");
            }
            
            // Configurer les contrôles
            txtPrixTotal.ReadOnly = true;
            txtQuantite.Minimum = 1;
            
            // Lier les événements
            comboMenu.SelectedIndexChanged += comboMenu_SelectedIndexChanged;
            txtQuantite.ValueChanged += txtQuantite_ValueChanged;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", 
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void ChargerCommandeDansFormulaire()
    {
        if (commandeCourante == null) return;
    
        // 1. Trouver et sélectionner le bon Menu dans le Combo
        foreach (var item in comboMenu.Items)
        {
            if (item.ToString().StartsWith(commandeCourante.IdMenu.ToString() + " -"))
            {
                comboMenu.SelectedItem = item;
                break;
            }
        }
    
        // 2. Trouver et sélectionner le bon Client
        foreach (var item in comboClient.Items)
        {
            if (item.ToString().StartsWith(commandeCourante.IdClient.ToString() + " -"))
            {
                comboClient.SelectedItem = item;
                break;
            }
        }
    
        // 3. Remplir les autres champs
        txtQuantite.Value = commandeCourante.Quantite; 
        txtPrixTotal.Value = (decimal)commandeCourante.PrixTotal; 
        txtDescription.Text = commandeCourante.Description ?? "";
    }
    
    private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
    {
        CalculerPrixTotal();
        CalculerQuantiteMax();
    }
    
    private void txtQuantite_ValueChanged(object sender, EventArgs e)
    {
        CalculerPrixTotal();
    }
    
    private void CalculerQuantiteMax()
    {   
        if (comboMenu.SelectedIndex < 0) return;
        
        try
        {
            // Extraire l'ID du menu sélectionné
            string selectedText = comboMenu.SelectedItem.ToString();
            string idPart = selectedText.Split('-')[0].Trim();
            
            if (int.TryParse(idPart, out int menuId))
            {
                // Trouver le menu pour récupérer sa quantité disponible
                var menu = menus.FirstOrDefault(m => m.Id == menuId);
                if (menu != null)
                {
                    // La quantité maximum est la quantité disponible + la quantité déjà commandée
                    int quantiteDisponible = menu.Quantite;
                    int quantiteActuelle = commandeCourante.Quantite;
                    txtQuantite.Maximum = quantiteDisponible + quantiteActuelle;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur de calcul de quantité max: {ex.Message}");
        }
    }
    
    private void CalculerPrixTotal()
    {
        if (comboMenu.SelectedIndex < 0 || txtQuantite.Value <= 0) return;
        
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
                    decimal prixTotal = (decimal)menu.PrixUnitaire * txtQuantite.Value;
                    txtPrixTotal.Value = prixTotal;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur de calcul: {ex.Message}");
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
            
            // Calculer le prix total
            double prixTotal = (double)menuSelectionne.PrixUnitaire * (int)txtQuantite.Value;
            
            // Mettre à jour l'objet commande
            commandeCourante.IdMenu = idMenu;
            commandeCourante.IdClient = idClient;
            commandeCourante.Quantite = (int)txtQuantite.Value;
            commandeCourante.PrixTotal = prixTotal;
            commandeCourante.Description = txtDescription.Text;
            
            // Afficher message d'attente
            AfficherMessage("⏳ Enregistrement en cours...", Color.Blue);
            this.Refresh(); 
            
            // Appeler le contrôleur
            bool succes = controller.ModifierCommande(commandeCourante);
            
            // Gérer la réponse
            if (succes)
            {
                MessageBox.Show($"Commande modifiée avec succès!", 
                              "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                AfficherMessage("Échec de la modification", Color.Red);
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
            MessageBox.Show($"Erreur: {ex.Message}", 
                          "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void AfficherMessage(string message, Color color)
    {
        lblMessage.Text = message;
        lblMessage.ForeColor = color;
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
    
    private void btnAnnuler_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}