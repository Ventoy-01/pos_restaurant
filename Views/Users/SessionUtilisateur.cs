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
        
        // public static bool ALeDroit(params string[] roles)
        // {
        //     if (!EstConnecte) return false;
        //     
        //     foreach (var role in roles)
        //     {
        //         if (UtilisateurCourant.Role == role)
        //             return true;
        //     }
        //     
        //     return false;
        // }
        
        public static void Deconnecter()
        {
            UtilisateurCourant = null;
        }
    }
