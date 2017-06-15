using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAO
{
    public class BestelItemDAO
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
            string com = "SELECT Bestel_Item.Prijs, Bestel_Item.Aantal, Menu_Item.Gerecht, Menu_Categorie.BTW" +
                         " FROM Bestel_Item" +
                         " INNER JOIN Menu_Item" +
                                " ON Bestel_Item.Menu_Item_ID = Menu_Item.ID" +
                         " INNER JOIN Menu_Categorie" +
                                " ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.ID" +
                         " WHERE Bestel_ID=@id";

            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", bestelId);
            conn.Open();
            SqlDataReader reader = c.ExecuteReader();
            List<BestelItem> items = new List<BestelItem>();


            while (reader.Read())
            {
                double prijs = reader.GetDouble(0);
                int aantal = reader.GetInt32(1);
                string gerecht = reader.GetString(2);
                int btw = reader.GetInt32(3);
                BestelItem item = new BestelItem(new MenuItem(gerecht, prijs, new Menucategorie(btw)), aantal);
                items.Add(item);
            }
            conn.Close();
            return items;
        }
        public void UpdateBestelitem(int bestellingid, Status updatestatus, string gerecht)
        {
            string stringstatus = updatestatus.ToString();
            SqlCommand command = new SqlCommand("UPDATE Bestel_Item SET Status = @st FROM Bestel_Item INNER JOIN Menu_Item ON Bestel_Item.Menu_Item_ID = Menu_Item.ID WHERE Menu_Item.Gerecht = @mg AND Bestel_Item.Bestel_ID = @id; ", conn);
            command.Parameters.AddWithValue("@id", bestellingid);
            command.Parameters.AddWithValue("@st", stringstatus);
            command.Parameters.AddWithValue("@mg", gerecht);

            conn.Open();
            command.ExecuteNonQuery();

            conn.Close();
        }
        public List<BestelItem> GetBestellingItemsByBestellingId(int bestelId)
        {
            string com = "SELECT Bestel_Item.Aantal, Menu_Item.Gerecht, Bestel_Item.Status" +
                         " FROM Bestel_Item" +
                         " INNER JOIN Menu_Item" +
                                " ON Bestel_Item.Menu_Item_ID = Menu_Item.ID" +
                         " WHERE Bestel_ID=@id";

            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", bestelId);
            conn.Open();
            SqlDataReader reader = c.ExecuteReader();
            List<BestelItem> items = new List<BestelItem>();


            while (reader.Read())
            {
                int aantal = reader.GetInt32(0);
                string gerecht = reader.GetString(1);
                string inputstatus = reader.GetString(2);
                Status status = (Status)Enum.Parse(typeof(Status), inputstatus);
                BestelItem item = new BestelItem(new MenuItem(gerecht), aantal, status);
                items.Add(item);
            }

            conn.Close();
            return items;
        }
    }
}