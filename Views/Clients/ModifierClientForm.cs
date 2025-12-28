using Pos_Restaurant.Models;


namespace Pos_Restaurant.Views.Clients;

using Pos_Restaurant.Controllers;

public partial class ModifierClientForm : Form
{
    private ClientsModel clientCourant;
    private ClientsController controller;
    public ModifierClientForm(ClientsModel client)
    {
        InitializeComponent();
        controller = new ClientsController();
        clientCourant = client;

        ChargerClientDansFormulaire();
    }

    private void ChargerClientDansFormulaire()
    {
        txtNom.Text = clientCourant.Nom;
        txtPrenom.Text = clientCourant.Prenom;
        comboSexe.Text = clientCourant.Sexe;
        txtTelephone.Text = clientCourant.Telephone;
        txtEmail.Text = clientCourant.Email;
        txtMontantDette.Text = clientCourant.MontantDette.ToString("0.00");
    }
    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        // Validation minimale
        if (string.IsNullOrWhiteSpace(txtNom.Text))
        {
            MessageBox.Show("Le nom est obligatoire");
            return;
        }

        if (!double.TryParse(txtMontantDette.Text, out double dette))
        {
            MessageBox.Show("Montant de dette invalide");
            return;
        }

        // Mise à jour de l'objet
        clientCourant.Nom = txtNom.Text.Trim();
        clientCourant.Prenom = txtPrenom.Text.Trim();
        clientCourant.Sexe = comboSexe.Text;
        clientCourant.Telephone = txtTelephone.Text.Trim();
        clientCourant.Email = txtEmail.Text.Trim();
        clientCourant.MontantDette = dette;

        // Appel contrôleur
        bool succes = controller.ModifierClent(clientCourant);

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