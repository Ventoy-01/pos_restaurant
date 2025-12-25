

using MySql.Data.MySqlClient;
using System;

namespace Pos_Restaurant.Data
{
    public class DbConnection
    {
        private static string connectionString = "Server=localhost; Database=pos; Uid=root; Pwd=vinchysql";

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
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    // Retourner le message d'erreur détaillé
                    return (false, $"Erreur MySQL #{ex.Number}: {ex.Message}");
                }
                catch (Exception ex)
                {
                    return (false, $"Erreur: {ex.Message}");
                }
            }
        // public static bool TestConnection1()
        // {
        //     try
        //     {
        //         using (var conn = GetConnection())
        //         {
        //             conn.Open();
        //             return true;
        //         }
        //     }
        //     catch (Exception)
        //     {
        //         return false;
        //     }
        // }
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
                // Log l'erreur si nécessaire
            }
        }
    }
}