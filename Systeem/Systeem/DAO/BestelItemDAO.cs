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
            string com = "SELECT Bestel_Item.Prijs, Bestel_Item.Aantal, Menu_Item.Gerecht, Menu_Categorie.BTW"+ 
                         " FROM Bestel_Item"+
                         " INNER JOIN Menu_Item" + 
                                " ON Bestel_Item.Menu_Item_ID = Menu_Item.ID"+
                         " INNER JOIN Menu_Categorie"+
                                " ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.ID"+
                         " WHERE Bestel_ID=@id";

            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", bestelId);

            SqlDataReader reader = c.ExecuteReader();
            List<BestelItem> items = new List<BestelItem>();

            conn.Open();
            while (reader.Read())
            {
                double prijs = reader.GetFloat(0);
                int aantal = reader.GetInt32(1);
                string gerecht = reader.GetString(2);
                int btw = reader.GetInt32(3);
                BestelItem item = new BestelItem(new MenuItem(gerecht,prijs,new Menucategorie(btw)), aantal);
                items.Add(item);
            }
            conn.Close();
            return items;
        }
    }
}