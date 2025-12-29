using Pos_Restaurant.Data;

namespace Pos_Restaurant.Dao;

using MySqlConnector;
using Pos_Restaurant.Models;
using Pos_Restaurant.Services;


public class PaiementsDao : IDao<PaiementsModel>
{
    private MySqlConnection conn = null;
    private MySqlCommand cmd = null;
    private MySqlDataReader dr = null;
    
    public PaiementsDao()
    {
        
    }

    public int Enregistrer(PaiementsModel e)
    {
        try
        {
            conn = DbConnection.GetConnection();
            conn.Open();
            string sql = "INSERT INTO paiements (IdCommande, Montant,  ModePaiement) " +
                         "VALUES (@IdCommande, @Montant, @ModePaiement)";
            using ( cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@IdCommande", e.IdCommande);
                cmd.Parameters.AddWithValue("@Montant", e.Montant);
                cmd.Parameters.AddWithValue("@ModePaiement", e.ModePaiement);

                int result = cmd.ExecuteNonQuery();
                return result;
                
            }
            
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }

    public int Modifier(PaiementsModel e)
    {
        try
        {
            conn = DbConnection.GetConnection();
            conn.Open();
            string sql =
                "UPDATE paiements SET IdCommande=@IdCommande, Montant=@Montant,  ModePaiement=@ModePaiement WHERE Id=@Id ";
            using ( cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@IdCommande", e.IdCommande);
                cmd.Parameters.AddWithValue("@Montant", e.Montant);
                cmd.Parameters.AddWithValue("@ModePaiement", e.ModePaiement);
                cmd.Parameters.AddWithValue("@Id", e.Id);

                int result = cmd.ExecuteNonQuery();
                return result;
                
            }
            
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }    }

    public int Supprimer(string id)
    {
        //pour supprimer un client
        try
        {
            int  idValue = int.Parse(id);
            conn = DbConnection.GetConnection();
            conn.Open();
            string req = "DELETE FROM paiements WHERE Id = @Id";
            using ( cmd = new MySqlCommand(req, conn))
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

    public PaiementsModel Rechercher(string id)
    {
        throw new NotImplementedException();
    }

    public List<PaiementsModel> Lister()
    {
        List<PaiementsModel> paiements = new List<PaiementsModel>();
        try
        {
            conn = DbConnection.GetConnection();
            conn.Open();
            string req = @"SELECT * FROM paiements";
                
                
            using (cmd = new MySqlCommand(req, conn))
            {
                dr = cmd.ExecuteReader();
                    
                while (dr.Read())
                {
                    paiements.Add(new PaiementsModel()
                    {
                        Id = dr.GetInt32("Id"),
                        IdCommande = dr.GetInt32("IdCommande"),
                        Montant = dr.GetDouble("Montant"),
                        DatePaiement = dr.GetDateTime("DatePaiement"),
                        ModePaiement = dr.GetString("ModePaiement"),
                    });
                }
                    
                return paiements;
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