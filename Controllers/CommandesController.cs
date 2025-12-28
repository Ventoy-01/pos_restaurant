using Pos_Restaurant.Dao;

namespace Pos_Restaurant.Controllers;
using Pos_Restaurant.Models;

public class CommandesController
{
    private CommandesDao commandesDao;
    
    public CommandesController()
    {
        commandesDao = new CommandesDao();
    }
    
    public bool EnregistrerCommande(CommandesModel commande)
    {
        try
        {
            // Validation des données
            if (commande == null)
            {
                throw new ArgumentNullException(nameof(commande), "La Commande ne peut pas être null");
            }
                
            // if (string.IsNullOrWhiteSpace(commande.Nom))
            // {
            //     throw new ArgumentException("Le nom du menu est obligatoire");
            // }
                
            // if (commande.PrixUnitaire <= 0)
            // {
            //     throw new ArgumentException("Le prix unitaire doit être positif");
            // }
                
            // Appel au DAO
            int result = commandesDao.Enregistrer(commande);
                
            // Retourne true si au moins une ligne a été affectée
            return result > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur dans CommandeController.EnregistrerCommande: {ex.Message}");
            throw; // Relance l'exception pour que le formulaire puisse l'attraper
        }
    }

    public List<CommandesModel> ListerCommandes()
    {
        List<CommandesModel> commandes = new List<CommandesModel>();
        try
        {

            commandes = commandesDao.Lister();
            return commandes;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
}