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
        try
        {
            if (!ValiderSaisieMenu())
            {
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
        }catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }
    private bool ValiderSaisieMenu()
    {
        // 1. Vérification du Nom (non vide)
        if (string.IsNullOrWhiteSpace(txtNom.Text))
        {
            MessageBox.Show("Le nom du menu est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNom.Focus();
            return false;
        }

        // 2. Vérification du Prix (doit être un nombre > 0)
        if (!double.TryParse(txtPrixUnitaire.Text, out double prix) || prix <= 0)
        {
            MessageBox.Show("Veuillez saisir un prix valide supérieur à 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPrixUnitaire.Focus();
            return false;
        }

        // 3. Vérification de la Quantité (NumericUpDown)
        if (txtQuantite.Value <= 0)
        {
            MessageBox.Show("La quantité doit être supérieure à 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtQuantite.Focus();
            return false;
        }

        // 4. Vérification de la Catégorie (ComboBox)
        if (comboType.SelectedIndex == -1)
        {
            MessageBox.Show("Veuillez sélectionner un type de menu.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            comboType.Focus();
            return false;
        }

        return true; 
    }
}