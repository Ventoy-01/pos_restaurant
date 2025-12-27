using System.Collections;

namespace Pos_Restaurant.Controllers;

using Pos_Restaurant.Models;
using Pos_Restaurant.Dao;

public class UsersController
{
    private UsersDao usersDao;
    public UsersController()
    {
        usersDao = new UsersDao();
        
    }

    public bool EnregistrerUser(UsersModel user)
    {
        try
        {
            int result = usersDao.Enregistrer(user);
            return result > 0;
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Erreur lors de l'enregistrement de l'utilisateur.", e);
        }
    }

    public bool ModifierUser(UsersModel user)
    {
        try
        {
            int result = usersDao.Modifier(user);
            return result > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Erreur lors de la modification de l'utilisateur.", e);
        }
    }
    
    public bool SupprimerUser(string id)
    {
        try
        {
            int result = usersDao.Supprimer(id);
            return result > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Erreur lors de la suppression de l'utilisateur.", e);
        }
    }
    
    public List<UsersModel> ListerUsers()
    {
        try
        {
            return usersDao.Lister();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Erreur lors de la récupération de la liste des utilisateurs.", e);
        }
    }
    
    public ArrayList Authentifier(string username, string password)
    {
        ArrayList result = new ArrayList();
        try
        {
            UsersModel user = usersDao.Authentifier(username, password);
            if (user.Username == username && user.Password == password)
            {
                result.Add(true);
                result.Add(user);
                return result;
            }
            result.Add(false);
            result.Add(null);
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            result.Add(false);
            result.Add(null);
            return result;        }
    }
}