namespace Pos_Restaurant.Views.Menus;

using Pos_Restaurant.Models;
using Pos_Restaurant.Controllers;

public partial class ModifierMenuForm : Form
{
    private MenusModel menuCourant;
    private MenusController controller;

    public ModifierMenuForm(MenusModel menu)
    {
        InitializeComponent();
        controller = new MenusController();
        menuCourant = menu;

        ChargerMenuDansFormulaire();
    }

    private void ChargerMenuDansFormulaire()
    {
        txtNom.Text = menuCourant.Nom;
        comboType.Text = menuCourant.Type;
        txtQuantite.Text = menuCourant.Quantite.ToString();
        txtPrixUnitaire.Text = menuCourant.PrixUnitaire.ToString("0.00");
        txtDescription.Text = menuCourant.Description;
    }

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        // Validation minimale
        if (string.IsNullOrWhiteSpace(txtNom.Text))
        {
            MessageBox.Show("Le nom est obligatoire");
            return;
        }

        // Mise à jour de l'objet
        menuCourant.Nom = txtNom.Text.Trim();
        menuCourant.Type = comboType.Text.Trim();
        if (int.TryParse(txtQuantite.Text, out int quantite))
        {
            menuCourant.Quantite = quantite;
        }

        if (double.TryParse(txtPrixUnitaire.Text, out double prixUnitaire))
        {
            menuCourant.PrixUnitaire = prixUnitaire;
        }

        menuCourant.Description = txtDescription.Text.Trim();

        bool succes = controller.ModifierMenu(menuCourant);

        if (succes)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Échec de la modification");
        }
    }
}