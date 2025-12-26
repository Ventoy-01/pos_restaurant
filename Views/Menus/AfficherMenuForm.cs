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
    
    // Views/Menus/AfficherMenuForm.cs
    

    
    private void ChargerMenus()
    {
        dgvMenus.AutoGenerateColumns = false;
        dgvMenus.DataSource = controller.ListerMenus();
        
        
        Console.WriteLine($"il y a {controller.ListerMenus().Count} menus");
    }


}