using System;
using Pos_Restaurant.Dao;
using Pos_Restaurant.Models;
using System.Collections.Generic;
using Pos_Restaurant.Views.Menus;

namespace Pos_Restaurant.Controllers
{
    /// <summary>
    /// Contrôleur pour la gestion des menus
    /// </summary>
    public class MenusController
    {
        private  MenusDao menusDao;
        
        /// <summary>
        /// Constructeur
        /// </summary>
        public MenusController()
        {
            menusDao = new MenusDao();
        }
        
        /// <summary>
        /// Enregistre un nouveau menu
        /// </summary>
        /// <param name="menu">Objet menu à enregistrer</param>
        /// <returns>True si l'opération a réussi</returns>
        public bool Enregistrer(MenusModel menu)
        {
            try
            {
                // Validation des données
                if (menu == null)
                {
                    throw new ArgumentNullException(nameof(menu), "Le menu ne peut pas être null");
                }
                
                if (string.IsNullOrWhiteSpace(menu.Nom))
                {
                    throw new ArgumentException("Le nom du menu est obligatoire");
                }
                
                if (menu.PrixUnitaire <= 0)
                {
                    throw new ArgumentException("Le prix unitaire doit être positif");
                }
                
                // Appel au DAO
                int result = menusDao.Enregistrer(menu);
                
                // Retourne true si au moins une ligne a été affectée
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur dans MenusController.EnregistrerClient: {ex.Message}");
                throw; // Relance l'exception pour que le formulaire puisse l'attraper
            }
        }
        
        public List<MenusModel> ListerMenus()
        {
            try
            {
                return menusDao.Lister();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur dans MenusController.ListerMenus: {ex.Message}");
                throw;
            }
        }
        
        public bool supprimerMenu(int menuId)
        {
            try
            {
                int result = menusDao.Supprimer(menuId.ToString());
                return result > 0;
    
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur dans MenusController.Supprimer: {e.Message}");
                throw;
            }
        }
        

        public bool ModifierMenu(MenusModel menu)
        {
            try
            {
                menusDao = new MenusDao();
                int result = menusDao.Modifier(menu);
                return result > 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
    }
}