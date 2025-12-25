using System.Data.Common;
using Pos_Restaurant.Models;
using Pos_Restaurant.Services;
using MySql.Data.MySqlClient;
using Pos_Restaurant.Data;
using DbConnection = Pos_Restaurant.Data.DbConnection;


namespace Pos_Restaurant.Dao
{
    /// <summary>
    /// Description of MenuDAO.
    /// </summary>
    /// 
    public class MenuDao : IDao<MenusModel>
    {
        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private IDao<MenusModel> _daoImplementation;

        public MenuDao()
        {
        }

//		
        public void Save(MenusModel c)
        {
            try
            {
                // etablir la connection
                conn = DbConnection.GetConnection();
                // ouvrir la connection
                conn.Open();
                // Creation de la chaine de requete
//			
                string req = @"INSERT INTO menus (id, type) 
                               VALUES (@id, @type)";
                // passer la chaine de requete a un objet de MySqlCommand
                cmd = new MySqlCommand(req, conn);

                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@type", c.Type);
//					cmd.Parameters.AddWithValue("@type","Cru");
//					cmd.Parameters.AddWithValue("@quantite",30);
//					cmd.Parameters.AddWithValue("@prixUnitaire",20.01);
//					cmd.Parameters.AddWithValue("@description", "L'abre a pain");

                int result = cmd.ExecuteNonQuery();





                if (result > 0)
                {
                    MessageBox.Show("Enregistrement effectue", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Enregistrement  Non effectue", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }



            }
            catch (SystemException ex)
            {
                Console.WriteLine("Exception leve", ex.Message);
                //MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            DbConnection.CloseConnection(dr, cmd, conn);
        }

        public void Update(MenusModel s)
        {
            _daoImplementation.Update(s);
        }

        public void Delete(string id)
        {
            _daoImplementation.Delete(id);
        }

        public MenusModel Details(string s)
        {
            return _daoImplementation.Details(s);
        }

        public List<MenusModel> Display()
        {
            return _daoImplementation.Display();
        }
    }
}