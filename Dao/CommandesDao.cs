using MySqlConnector;
using Pos_Restaurant.Data;
using Pos_Restaurant.Models;
using Pos_Restaurant.Services;

namespace Pos_Restaurant.Dao;

public class CommandesDao : IDao<CommandesModel>
{

    private MySqlConnection conn = null;
    private MySqlCommand cmd = null;


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
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
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
                              SET type = @idMenu, 
                                  nom = @idClient, 
                                  quantite = @qte, 
                                  prix_unitaire = @prix, 
                                  description = @desc
                              WHERE id = @id";
                
                using (cmd = new MySqlCommand(req, conn))
                {
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    // cmd.Parameters.AddWithValue("@type", c.Type ?? "");
                    // cmd.Parameters.AddWithValue("@nom", c.Nom ?? "");
                    // cmd.Parameters.AddWithValue("@qte", c.Quantite);
                    // cmd.Parameters.AddWithValue("@prix", c.PrixUnitaire);
                    cmd.Parameters.AddWithValue("@desc", c.Description ?? "");
                    
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
            throw new NotImplementedException();
        }
}
