using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace Systeem.DAO
{
    class BestelItemDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;
        // hai

        public BestelItemDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }

        // Kayleigh
        public List<BestelItem> GetMenuItemsByBestellingId(int bestelId)
        {
            string com = "SELECT Menu_Item.Gerecht, Menu_Item.Prijs, Bestel_Item.Aantal FROM Bestel_Item INNER JOIN Menu_Item_ID ON Bestel_Item.Menu_Item_ID = Menu_Item.ID WHERE Bestel_ID=@id ";
            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", bestelId);

            SqlDataReader reader = c.ExecuteReader();
            List<BestelItem> items = new List<BestelItem>();

            conn.Open();
            while (reader.Read())
            {
                string gerecht = reader.GetString(0);
                double prijs = reader.GetFloat(1);
                int aantal = reader.GetInt32(2);
                BestelItem item = new BestelItem(new MenuItem(gerecht, prijs), aantal);
                items.Add(item);
            }
            conn.Close();
            return items;
        }
    }
}
