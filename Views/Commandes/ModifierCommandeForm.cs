namespace Pos_Restaurant.Views.Commandes;

using Pos_Restaurant.Models;
using Pos_Restaurant.Controllers;
public partial class ModifierCommandeForm : Form
{
    private CommandesModel commandeCourante;
    private CommandesController controller;
    
    public ModifierCommandeForm(CommandesModel commande)
    {
        controller = new CommandesController();
        commandeCourante = new CommandesModel();
        InitializeComponent();
        
        ChargerCommandeDansFormulaire();
    }


    private void ChargerCommandeDansFormulaire()
    {
        comboMenu.Text = commandeCourante.IdMenu.ToString();
        comboClient.Text = commandeCourante.IdClient.ToString();
        txtQuantite.Text = commandeCourante.Quantite.ToString();
        txtPrixTotal.Text = commandeCourante.PrixTotal.ToString("0.00");
        txtDescription.Text = commandeCourante.Description;
    }
    
    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        
    }
    
    
    
}