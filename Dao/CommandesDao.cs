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

                return result;
            }
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de l'ajout: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erreur lors de l'ajout du clien: {ex.Message}", ex);
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
                
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                string req = @"UPDATE commandes 
                              SET idMenu = @idMenu, 
                                  idClient = @idClient, 
                                  quantite = @qte, 
                                  prixTotal = @prixToal, 
                                  description = @desc
                              WHERE id = @id";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    cmd.Parameters.AddWithValue("@id", c.IdMenu);
                    cmd.Parameters.AddWithValue("@idClient", c.IdClient);
                    cmd.Parameters.AddWithValue("@qte", c.Quantite);
                    cmd.Parameters.AddWithValue("@prix", c.PrixTotal);
                    cmd.Parameters.AddWithValue("@desc", c.Description ?? "");
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    
                    
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

//Supprimer Commande
        public int Supprimer(String val)
        {
            throw new NotImplementedException();
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
                                Description = dr.GetString("description")
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
    
}
