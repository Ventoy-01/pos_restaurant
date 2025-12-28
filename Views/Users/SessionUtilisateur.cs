using System.Runtime.CompilerServices;

namespace Pos_Restaurant.Views.Users;

using Pos_Restaurant.Models;


public static class SessionUtilisateur
    {
        public static UsersModel UtilisateurCourant { get; set; }
        
        public static bool EstConnecte => UtilisateurCourant != null;
        
        public static bool ALeDroit(string role)
        {
            return EstConnecte && UtilisateurCourant.Role == role;
        }
        
        public static bool IsAdmin()
        {
            return (EstConnecte && UtilisateurCourant.Role == "admin");
        }
        
        public static void Deconnecter()
        {
            UtilisateurCourant = null;
        }
    }
