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


    public void ChargerCommandeDansFormulaire()
    {
        
    }
    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        
    }
    
    
    
}