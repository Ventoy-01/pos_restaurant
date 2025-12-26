namespace Pos_Restaurant.Controllers;

using Pos_Restaurant.Models;
using Pos_Restaurant.Dao;

public class ClientsController
{
    private ClientsDao clientsDao;

    public ClientsController()
    {
        clientsDao = new ClientsDao();
    }

    /// <summary>
    /// Enregistre un nouveau client
    /// </summary>
    /// <param name="client">Objet client à enregistrer</param>
    /// <returns>True si l'opération a réussi</returns>
    public bool EnregistrerClient(ClientsModel client)
    {
        try
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client), "Le client ne peut pas être null");
            }

            if (string.IsNullOrWhiteSpace(client.Nom) || string.IsNullOrWhiteSpace(client.Prenom))
            {
                throw new ArgumentException("Le nom et le prénom du client sont obligatoires");
            }

            int result = clientsDao.Enregistrer(client);

            return result > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur dans ClientsController.EnregistrerClient: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Récupère la liste des clients
    /// </summary>
    /// <returns>Liste des clients</returns>
    public List<ClientsModel> ListerClients()
    {
        try
        {
            return clientsDao.Lister();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur dans ClientsController.ListerClients: {ex.Message}");
            throw;
        }
    }

    public bool SupprimerClient(int clientId)
    {
        try
        {
            int result = clientsDao.Supprimer(clientId.ToString());
            return result > 0;

        }
        catch (Exception e)
        {
            Console.WriteLine($"Erreur dans ClientsController.Supprimer: {e.Message}");
            throw;
        }
    }
}