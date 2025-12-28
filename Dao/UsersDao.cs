
namespace Pos_Restaurant.Dao;

using MySqlConnector;

using Pos_Restaurant.Models;
using Pos_Restaurant.Services;
using Pos_Restaurant.Data;

public class UsersDao : IDao<UsersModel>
{
    public UsersDao()
    {
        
    }
    
    private MySqlConnection conn = null;
    private MySqlCommand cmd = null;
    private MySqlDataReader dr = null;
    private UsersModel userModel = null;
    
    public int Enregistrer(UsersModel u)
    {
        try
        {
            // Établir la connexion
            conn = DbConnection.GetConnection();

            // Ouvrir la connexion
            conn.Open();
            
            string req = @"INSERT INTO users (Username, Password, Role) 
                               VALUES (@Username, @Password, @Role)";
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                // Ajouter les paramètres
                cmd.Parameters.AddWithValue("@Username",u.Username);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@Role", u.Role);

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
            throw new Exception($"Erreur lors de l'ajout de l'utilisateur: {ex.Message}", ex);
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }

    public int Modifier(UsersModel e)
    {
        try
        {
            // Établir la connexion
            conn = DbConnection.GetConnection();

            // Ouvrir la connexion
            conn.Open();
            
            string req = @"UPDATE users SET Username=@Username, Password=@Password, Role=@Role WHERE Id=@Id";
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                // Ajouter les paramètres
                cmd.Parameters.AddWithValue("@Username", e.Username);
                cmd.Parameters.AddWithValue("@Password", e.Password);
                cmd.Parameters.AddWithValue("@Role", e.Role);
                cmd.Parameters.AddWithValue("@Id", e.Id);

                // Exécuter la commande
                int result = cmd.ExecuteNonQuery();

                return result;
            }
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de la modification: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erreur lors de la modification de l'utilisateur: {ex.Message}", ex);
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }

    public int Supprimer(string id)
    {
        try
        {
            // Établir la connexion
            conn = DbConnection.GetConnection();

            // Ouvrir la connexion
            conn.Open();
            
            string req = @"DELETE FROM users WHERE Id=@Id";
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                // Ajouter les paramètres
                cmd.Parameters.AddWithValue("@Id", id);

                // Exécuter la commande
                int result = cmd.ExecuteNonQuery();

                return result;
            }
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de la suppression: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erreur lors de la suppression de l'utilisateur: {ex.Message}", ex);
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }

    public UsersModel Rechercher(string id)
    {
        try
        {
            // Établir la connexion
            conn = DbConnection.GetConnection();

            // Ouvrir la connexion
            conn.Open();
            
            string req = @"SELECT * FROM users WHERE Id=@Id";
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                // Ajouter les paramètres
                cmd.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UsersModel user = new UsersModel
                        {
                            Id = reader.GetInt32("Id"),
                            Username = reader.GetString("Username"),
                            Password = reader.GetString("Password"),
                            Role = reader.GetString("Role")
                        };
                        return user;
                    }
                    else
                    {
                        return null; // Utilisateur non trouvé
                    }
                }
            }
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de la recherche: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erreur lors de la recherche de l'utilisateur: {ex.Message}", ex);
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }

    public List<UsersModel> Lister()
    {
        List<UsersModel> users = new List<UsersModel>();
        MySqlDataReader dr = null;
        try
        {
            // Établir la connexion
            conn = DbConnection.GetConnection();

            // Ouvrir la connexion
            conn.Open();

            string req = "SELECT * FROM users";
            
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                dr = cmd.ExecuteReader();
               
                    while (dr.Read())
                    {
                        UsersModel user = new UsersModel
                        {
                            Id = dr.GetInt32("Id"),
                            Username = dr.GetString("Username"),
                            Password = dr.GetString("Password"),
                            Role = dr.GetString("Role")
                        };
                        users.Add(user);
                    }
                
            }
            return users;
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de la liste: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erreur lors de la liste des utilisateurs: {ex.Message}", ex);
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }

    public UsersModel Authentifier(string user, string pwd)
    {

        try
        {
            conn = DbConnection.GetConnection();
            conn.Open();
            string req = @"SELECT * FROM users WHERE Username=@Username AND Password=@Password";
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                cmd.Parameters.AddWithValue("@Username", user);
                cmd.Parameters.AddWithValue("@Password", pwd);
                
                    dr = cmd.ExecuteReader();
               
                    if (dr.Read())
                    {
                         userModel = new UsersModel
                        {
                            Id = dr.GetInt32("Id"),
                            Username = dr.GetString("Username"),
                            Password = dr.GetString("Password"),
                            Role = dr.GetString("Role")
                        };
                    }
                    return userModel;
                
            }
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de l'authentification: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erreur lors de l'authentification de l'utilisateur: {ex.Message}", ex);
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}