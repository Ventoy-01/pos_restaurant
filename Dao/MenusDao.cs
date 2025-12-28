using System;
using System.Collections.Generic;
// using MySql.Data.MySqlClient;
using MySqlConnector;
using Pos_Restaurant.Data;
using Pos_Restaurant.Models;
using Pos_Restaurant.Services;

namespace Pos_Restaurant.Dao
{
    /// <summary>
    /// Implémentation du DAO pour la table Menus
    /// </summary>
    public class MenusDao : IDao<MenusModel>
    {
        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        
        public MenusDao()
        {
            // Constructeur
        }
        
        // CREATE - EnregistrerClient
        public int Enregistrer(MenusModel menu)
        {
            try
            {
                // Établir la connexion
                conn = DbConnection.GetConnection();
                
                // Ouvrir la connexion
            
                    conn.Open();

                // Création de la requête
                string req = @"INSERT INTO menus (type, nom, quantite, prixUnitaire, description) 
                               VALUES (@type, @nom, @qte, @prix, @desc)";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    cmd.Parameters.AddWithValue("@type", menu.Type ?? "");
                    cmd.Parameters.AddWithValue("@nom", menu.Nom ?? "");
                    cmd.Parameters.AddWithValue("@qte", menu.Quantite);
                    cmd.Parameters.AddWithValue("@prix", menu.PrixUnitaire);
                    cmd.Parameters.AddWithValue("@desc", menu.Description ?? "");
                    cmd.Parameters.AddWithValue("@actif", menu.Actif);
                    
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL lors de l'ajout: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de l'ajout du menu: {ex.Message}", ex);
            }
            finally
            {
                // Fermer la connexion
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
        
        // UPDATE - Modifier
        public int Modifier(MenusModel menu)
        {
            try
            {
                conn = DbConnection.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                string req = @"UPDATE menus 
                              SET type = @type, 
                                  nom = @nom, 
                                  quantite = @qte, 
                                  prixUnitaire = @prix, 
                                  description = @desc
                              WHERE id = @id";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    cmd.Parameters.AddWithValue("@id", menu.Id);
                    cmd.Parameters.AddWithValue("@type", menu.Type ?? "");
                    cmd.Parameters.AddWithValue("@nom", menu.Nom ?? "");
                    cmd.Parameters.AddWithValue("@qte", menu.Quantite);
                    cmd.Parameters.AddWithValue("@prix", menu.PrixUnitaire);
                    cmd.Parameters.AddWithValue("@desc", menu.Description ?? "");
                    
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL lors de la modification: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la modification du menu: {ex.Message}", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
        
        public int Supprimer(String val)
        {
        int id = int.Parse(val);
            try
            {
                conn = DbConnection.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                string req = "UPDATE menus SET actif = 0 WHERE id = @id";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL lors de la suppression: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la suppression du menu: {ex.Message}", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
        
        public MenusModel Rechercher(String val)
        {
            int id = int.Parse(val);
            
            try
            {
                conn = DbConnection.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                string req = "SELECT * FROM menus WHERE id = @id AND actif = 1";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    dr = cmd.ExecuteReader();
                    
                    if (dr.Read())
                    {
                        return new MenusModel
                        {
                            Id = dr.GetInt32(id),
                            Type = dr.GetString("type"),
                            Nom = dr.GetString("nom"),
                            Quantite = dr.GetInt32("quantite"),
                            PrixUnitaire = dr.GetDouble("prix_unitaire"),
                            Description = dr.GetString("description")
                        };
                    }
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL lors de la recherche: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la recherche du menu: {ex.Message}", ex);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                    
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
        
        //  - Lister tous les menus
        public List<MenusModel> Lister()
        {
            List<MenusModel> menus = new List<MenusModel>();
            
            try
            {
                conn = DbConnection.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                string req = "SELECT * FROM menus WHERE actif = 1 ORDER BY nom";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    dr = cmd.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        menus.Add(new MenusModel
                        {
                            Id = dr.GetInt32("id"),
                            Type = dr.GetString("type"),
                            Nom = dr.GetString("nom"),
                            Quantite = dr.GetInt32("quantite"),
                            PrixUnitaire = dr.GetDouble("prixUnitaire"),
                            Description = dr.GetString("description")
                        });
                    }
                    
                    return menus;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL lors du listage: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du listage des menus: {ex.Message}", ex);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                    
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
        
        
        public List<MenusModel> ListerDisponibles()
        {
            List<MenusModel> menus = new List<MenusModel>();
            
            try
            {
                conn = DbConnection.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                string req = "SELECT * FROM menus WHERE quantite > 0 AND actif = 1 ORDER BY nom";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    dr = cmd.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        menus.Add(new MenusModel
                        {
                            Id = dr.GetInt32("id"),
                            Type = dr.GetString("type"),
                            Nom = dr.GetString("nom"),
                            Quantite = dr.GetInt32("quantite"),
                            PrixUnitaire = dr.GetDouble("prix_unitaire"),
                            Description = dr.GetString("description")
                        });
                    }
                    
                    return menus;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur listage disponibles: {ex.Message}", ex);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                    
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
        
        public bool MettreAJourQuantite(int id, int nouvelleQuantite)
        {
            try
            {
                conn = DbConnection.GetConnection();
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                string req = "UPDATE menus SET quantite = @qte WHERE id = @id";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@qte", nouvelleQuantite);
                    
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur mise à jour quantité: {ex.Message}", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
        
        public bool ReduireQuantite(int id, int quantiteAReduire)
        {
            try
            {
                // Vérifier d'abord si la quantité est suffisante
                var menu = Rechercher(id.ToString());
                if (menu == null || menu.Quantite < quantiteAReduire)
                    return false;
                
                // Réduire la quantité
                return MettreAJourQuantite(id, menu.Quantite - quantiteAReduire);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur réduction quantité: {ex.Message}", ex);
            }
        }
    }
}