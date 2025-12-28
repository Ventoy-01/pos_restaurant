using MySqlConnector;
using Pos_Restaurant.Data;
using Pos_Restaurant.Models;
using Pos_Restaurant.Services;

namespace Pos_Restaurant.Dao;

public class ClientsDao:IDao<ClientsModel>
{
    private MySqlConnection conn = null;
    private MySqlCommand cmd = null;


    //Ajouter un client
    public int Enregistrer(ClientsModel e)
    {
        try
        {
            // Établir la connexion
            conn = DbConnection.GetConnection();

            // Ouvrir la connexion

            conn.Open();
            
            string req = @"INSERT INTO clients (Nom, Prenom, Sexe, Telephone, Email, MontantDette) 
                               VALUES (@Nom, @Prenom, @Sexe, @Telephone, @Email, @MontantDette)";
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                // Ajouter les paramètres
                cmd.Parameters.AddWithValue("@Nom", e.Nom);
                cmd.Parameters.AddWithValue("@Prenom", e.Prenom);
                cmd.Parameters.AddWithValue("@Sexe", e.Sexe);
                cmd.Parameters.AddWithValue("@Telephone", e.Telephone);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@MontantDette", e.MontantDette);

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
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
    
    //Modifier un client

    public int Modifier(ClientsModel e)
    {
        try
        {
            conn = DbConnection.GetConnection();
            conn.Open();
            string req = @"UPDATE clients 
                           SET Nom = @Nom, Prenom = @Prenom, Sexe = @Sexe, Telephone = @Telephone, 
                               Email = @Email, MontantDette = @MontantDette 
                           WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                cmd.Parameters.AddWithValue("@Nom", e.Nom);
                cmd.Parameters.AddWithValue("@Prenom", e.Prenom);
                cmd.Parameters.AddWithValue("@Sexe", e.Sexe);
                cmd.Parameters.AddWithValue("@Telephone", e.Telephone);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@MontantDette", e.MontantDette);
                cmd.Parameters.AddWithValue("@Id", e.Id);

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
            throw new Exception($"Erreur lors de la modification du client: {ex.Message}", ex);
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
        //pour supprimer un client
        try
        {
           int  idValue = int.Parse(id);
            conn = DbConnection.GetConnection();
            conn.Open();
            string req = "DELETE FROM clients WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                cmd.Parameters.AddWithValue("@Id", idValue);
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
            throw new Exception($"Erreur lors de la suppression du client: {ex.Message}", ex);
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }

    public ClientsModel Rechercher(string id)
    {
        throw new NotImplementedException();
    }

    public List<ClientsModel> Lister()
    {
        List<ClientsModel> clients = new List<ClientsModel>();
        MySqlDataReader dr = null;
        try
        {
            // Établir la connexion
            conn = DbConnection.GetConnection();

            // Ouvrir la connexion
            conn.Open();

            string req = "SELECT * FROM clients";
            
            using (MySqlCommand cmd = new MySqlCommand(req, conn))
            {
                dr = cmd.ExecuteReader();
               
                    while (dr.Read())
                    {
                        ClientsModel client = new ClientsModel
                        {
                            Id = dr.GetInt32("Id"),
                            Nom = dr.GetString("Nom"),
                            Prenom = dr.GetString("Prenom"),
                            Sexe = dr.GetString("Sexe"),
                            Telephone = dr.GetString("Telephone"),
                            Email = dr.GetString("Email"),
                            MontantDette = dr.GetDouble("MontantDette")
                        };
                        clients.Add(client);
                    }
            }

            return clients;
        }
        catch (MySqlException ex)
        {
            throw new Exception($"Erreur MySQL lors de la récupération des clients: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erreur lors de la récupération des clients: {ex.Message}", ex);
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}