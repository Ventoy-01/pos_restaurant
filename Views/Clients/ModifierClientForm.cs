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
        txtTelephone.Text = clientCourant.Telephone.Substring(5);
        txtEmail.Text = clientCourant.Email;
        txtMontantDette.Text = clientCourant.MontantDette.ToString("0.00");
    }
    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        if (!ValiderSaisieClient())
        {
            return;
        }

        // Mise à jour de l'objet
        clientCourant.Nom = txtNom.Text.Trim();
        clientCourant.Prenom = txtPrenom.Text.Trim();
        clientCourant.Sexe = comboSexe.Text;
        clientCourant.Telephone = "+509 "+txtTelephone.Text.Trim();
        clientCourant.Email = txtEmail.Text.Trim();
        clientCourant.MontantDette = (Convert.ToDouble(txtMontantDette.Text));

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

        if (!double.TryParse(txtMontantDette.Text, out double montantDette))
        {
            MessageBox.Show("Le montant doit etre un nombre.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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