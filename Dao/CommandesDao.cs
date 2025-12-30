using System.Collections;
using MySqlConnector;
using Pos_Restaurant.Data;
using Pos_Restaurant.Models;
using Pos_Restaurant.Services;

namespace Pos_Restaurant.Dao;

public class CommandesDao : IDao<CommandesModel>
{

    private MySqlConnection conn = null;
    private MySqlCommand cmd = null;
    private MySqlDataReader dr = null;
    private MySqlTransaction transaction = null;


    //Ajouter une commande
    public int Enregistrer(CommandesModel c)
    {

        try
        {
            // Établir la connexion
            conn = DbConnection.GetConnection();
            // Ouvrir la connexion
            conn.Open();

            string req = @"INSERT INTO commandes (IdMenu, IdClient, Quantite, PrixTotal, description) 
                               VALUES (@idMenu, @idClient,@Quantite, @PrixTotal, @description)";
            using ( cmd = new MySqlCommand(req, conn))
            {
                
                // Ajouter les paramètres
                cmd.Parameters.AddWithValue("@idMenu", c.IdMenu);
                cmd.Parameters.AddWithValue("@idClient", c.IdClient);
                cmd.Parameters.AddWithValue("@Quantite", c.Quantite);
                cmd.Parameters.AddWithValue("@PrixTotal", c.PrixTotal);
                cmd.Parameters.AddWithValue("@description", c.Description);
                

                // Exécuter la commande
                int result = cmd.ExecuteNonQuery();
                // return result;
                string sqlUpdateStock = "UPDATE menus SET Quantite = quantite - @qte WHERE id = @idM";
                using (var cmdUpdate = new MySqlCommand(sqlUpdateStock, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@qte", c.Quantite);
                    cmdUpdate.Parameters.AddWithValue("@idM", c.IdMenu);
                    cmdUpdate.ExecuteNonQuery();
                }
                
                
                return result;
            }
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de l'ajout: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erreur lors de l'ajout de la commande: {ex.Message}", ex);
        }
        finally
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }


    //Modifier Commande
    public int Modifier(CommandesModel c)
    {
        try
        {
            conn = DbConnection.GetConnection();
            conn.Open();
           
                // 1. Récupérer l'ancienne quantité avant de modifier
                int ancienneQuantite = 0;
                string selectReq = "SELECT quantite FROM commandes WHERE id = @id";
                using (var selectCmd = new MySqlCommand(selectReq, conn))
                {
                    selectCmd.Parameters.AddWithValue("@id", c.Id);
                    object result = selectCmd.ExecuteScalar();
                    if (result != null)
                        ancienneQuantite = Convert.ToInt32(result);
                }

                int difference = c.Quantite - ancienneQuantite;

                // 3. Mettre à jour le stock dans la table menus
                string updateStockReq = "UPDATE menus SET Quantite = Quantite - @diff WHERE id = @idMenu";
                using (var stockCmd = new MySqlCommand(updateStockReq, conn, transaction))
                {
                    stockCmd.Parameters.AddWithValue("@diff", difference);
                    stockCmd.Parameters.AddWithValue("@idMenu", c.IdMenu);
                    stockCmd.ExecuteNonQuery();
                }

                // 4. Mettre à jour la commande
                string req = @"UPDATE commandes 
                              SET idMenu = @idMenu, 
                                  idClient = @idClient, 
                                  quantite = @qte, 
                                  prixTotal = @prix, 
                                  description = @desc
                              WHERE id = @id";

                int rowsAffected = 0;
                using (var cmd = new MySqlCommand(req, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@idMenu", c.IdMenu);
                    cmd.Parameters.AddWithValue("@idClient", c.IdClient);
                    cmd.Parameters.AddWithValue("@qte", c.Quantite);
                    cmd.Parameters.AddWithValue("@prix", c.PrixTotal);
                    cmd.Parameters.AddWithValue("@desc", c.Description);
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    rowsAffected = cmd.ExecuteNonQuery();
                }

                return rowsAffected;
        
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL : {ex.Message}");
        }
        finally
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }

        //Supprimer Commande
    public int Supprimer(String val)
    {
        int id = int.Parse(val);
        int result = 0;

        try
        {
            conn = DbConnection.GetConnection();
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            int idMenu = 0;
            int quantiteARendre = 0;

            string selectReq = "SELECT IdMenu, Quantite FROM commandes WHERE id = @id";
            using (MySqlCommand selectCmd = new MySqlCommand(selectReq, conn))
            {
                selectCmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader dr = selectCmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        idMenu = dr.GetInt32("IdMenu"); 
                        quantiteARendre = dr.GetInt32("Quantite");
                    }
                } 
            }

            if (idMenu == 0) return 0;

            string deleteReq = "DELETE FROM commandes WHERE id = @id";
            using (MySqlCommand deleteCmd = new MySqlCommand(deleteReq, conn))
            {
                deleteCmd.Parameters.AddWithValue("@id", id);
                result = deleteCmd.ExecuteNonQuery();
            }

            string updateReq = "UPDATE menus SET Quantite = Quantite + @quantite WHERE id = @IdMenu";
            using (MySqlCommand updateCmd = new MySqlCommand(updateReq, conn))
            {
                updateCmd.Parameters.AddWithValue("@quantite", quantiteARendre);
                updateCmd.Parameters.AddWithValue("@IdMenu", idMenu);
                updateCmd.ExecuteNonQuery();
            }

            return result;
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de la suppression : {ex.Message}");
        }
        finally
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }

        //Rechercher Commande
        public CommandesModel Rechercher(string val)
        {
            throw new NotImplementedException();
        }

        
        //Lister Commande
        public List<CommandesModel> Lister()
        {
            List<CommandesModel> commandes = new List<CommandesModel>();
            try
            {
                conn = DbConnection.GetConnection();
                conn.Open();
                string req = @"SELECT * FROM commandes";
                
                
                    using (cmd = new MySqlCommand(req, conn))
                    {
                        dr = cmd.ExecuteReader();
                    
                        while (dr.Read())
                        {
                            commandes.Add(new CommandesModel()
                            {
                                Id = dr.GetInt32("id"),
                                IdMenu = dr.GetInt32("IdMenu"),
                                IdClient = dr.GetInt32("IdClient"),
                                Quantite = dr.GetInt32("Quantite"),
                                PrixTotal = dr.GetDouble("prixTotal"),
                                Description = dr.GetString("description"),
                                DateCommande = dr.GetDateTime("DateCommande") 
                            });
                        }
                    
                        return commandes;
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

        public List<CommandesModel> ListerCommandeMenuClient()
        {
            List<CommandesModel> commandes = new List<CommandesModel>();
            try
            {
                conn = DbConnection.GetConnection();
                conn.Open();
                string req = @"SELECT c.*, 
                               m.nom AS NomMenu,
                               m.type AS Type,
                               m.prixUnitaire AS PrixUnitaire, 
                               cl.nom AS NomClient
                               FROM commandes c
                               INNER JOIN menus m ON c.idMenu = m.id
                               INNER JOIN clients cl ON c.idClient = cl.id
                               ORDER BY c.id DESC";


                using (cmd = new MySqlCommand(req, conn))
                {
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            commandes.Add(new CommandesModel
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                IdMenu = Convert.ToInt32(dr["idMenu"]),
                                IdClient = Convert.ToInt32(dr["idClient"]),
                                Quantite = Convert.ToInt32(dr["quantite"]),
                                PrixTotal = Convert.ToDouble(dr["prixTotal"]),
                                Description = dr["description"].ToString(),

                                // Nouvelles
                                NomMenu = dr["NomMenu"].ToString(),
                                Type = dr["Type"].ToString(),
                                NomClient = dr["NomClient"].ToString(),
                                PrixUnitaire = Convert.ToDouble(dr["PrixUnitaire"])
                            });
                        }
                    }
                }

                return commandes;
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
}
