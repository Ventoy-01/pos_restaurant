namespace Pos_Restaurant.Controllers;

using Pos_Restaurant.Dao;
using Pos_Restaurant.Models;

public class PaiementsController
{
    private PaiementsDao paiementsDao;
    
    public PaiementsController()
    {
        paiementsDao = new PaiementsDao();
    }
    
    public bool AjouterPaiement(PaiementsModel paiement)
    {
        try
        {
            if (paiement == null)
            {
                throw new ArgumentNullException(nameof(paiement), "Le paiement ne peut pas être null");
            }
            
            if (paiement.Montant <= 0)
            {
                throw new ArgumentException("Le montant doit être positif");
            }
            
            int result = paiementsDao.Enregistrer(paiement);
            return result > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur dans PaiementsController.Enregistrer: {ex.Message}");
            throw;
        }
    }
    
    public bool ModifierPaiement(PaiementsModel paiement)
    {
        try
        {
            if (paiement == null)
            {
                throw new ArgumentNullException(nameof(paiement), "Le paiement ne peut pas être null");
            }
            
            if (paiement.Montant <= 0)
            {
                throw new ArgumentException("Le montant doit être positif");
            }
            
            int result = paiementsDao.Modifier(paiement);
            return result > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur dans PaiementsController.Modifier: {ex.Message}");
            throw;
        }
    }

    public List<PaiementsModel> ListerPaiement()
    {
        
        try
        {
            return paiementsDao.Lister();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public bool SupprimerPaiement(string id)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("L'ID du paiement ne peut pas être vide", nameof(id));
            }
            
            int result = paiementsDao.Supprimer(id);
            return result > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur dans PaiementsController.Supprimer: {ex.Message}");
            throw;
        }
    }
    
}