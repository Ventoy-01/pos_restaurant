

// using MySql.Data.MySqlClient;
using MySqlConnector;
using System;

namespace Pos_Restaurant.Data
{
    public class DbConnection
    {
        public static string connectionString = "Server=127.0.0.1;Port=3306;Database=pos;Uid=root;Pwd=;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static (bool Success, string ErrorMessage) TestConnection()
            {
                try
                {
                    using (var conn = GetConnection())
                    {
                        conn.Open();
                        return (true, "Connexion réussie");
                    }
                }
                catch (MySqlException ex)
                {
                    // Retourner le message d'erreur détaillé
                    return (false, $"Erreur MySQL #{ex.Number}: {ex.Message}");
                }
                catch (Exception ex)
                {
                    return (false, $"Erreur: {ex.Message}");
                }
            }

            public static void CloseConnection(MySqlDataReader dr, MySqlCommand cmd, MySqlConnection conn)
            {
                try
                {
                    if (dr != null && !dr.IsClosed)
                    {
                        dr.Close();
                    }
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Erreur lors de la fermeture des ressources de la base de données.");
                }
            }
    }
}