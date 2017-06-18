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

        public BestelItemDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }

        // Kayleigh
        private BestelItem ReadBestelItem(SqlDataReader reader)
        {
            try
            {
                int BestelItemID = reader.GetInt32(0);
                int bestelId = reader.GetInt32(1);
                int menuItemID = reader.GetInt32(2);
                int aantal = reader.GetInt32(3);
                Status status = (Status)Enum.Parse(typeof(Status), reader.GetString(4));
                string opmerking = "";

                double BestelItemPrijs = reader.GetDouble(6);
                DateTime bestelItemTijd = reader.GetDateTime(7);
                string MenuItemNaam = reader.GetString(9);
                double MenuItemPrijs = reader.GetDouble(10);
                int MenuItemVoorraad = reader.GetInt32(11);

                int MenuCatId = reader.GetInt32(12);
                int tafelId = reader.GetInt32(14);
                int medId = reader.GetInt32(15);
                bool betaald = reader.GetBoolean(16);
                string menuCatNaam = reader.GetString(18);
                int btw = reader.GetInt32(19);
                int MenuKaartId = reader.GetInt32(20);
                string menukaartNaam = reader.GetString(22);
                bool tafelstatus = reader.GetBoolean(24);
                string voornaam = reader.GetString(26);
                string achternaam = reader.GetString(27);
                Functie functie = (Functie)Enum.Parse(typeof(Functie), reader.GetString(28));
                string wachtwoord = reader.GetString(29);


                MenuKaart kaart = new MenuKaart(MenuKaartId, menukaartNaam);
                Menucategorie cat = new Menucategorie(MenuCatId, menuCatNaam, btw, kaart);
                MenuItem menuitem = new MenuItem(menuItemID, MenuItemNaam, MenuItemPrijs, MenuItemVoorraad, cat);
                Tafel tafel = new Tafel(tafelId, tafelstatus);
                Medewerker med = new Medewerker(medId, voornaam, achternaam, functie, wachtwoord);
                Bestelling best = new Bestelling(bestelId, betaald, tafel, med);
                BestelItem bestelItem = new BestelItem(BestelItemID, best, menuitem, BestelItemPrijs, aantal, status, opmerking, bestelItemTijd);
                return bestelItem;
            }
            catch
            {
                return null;
            }

        }

        // Kayleigh Vossen
        public List<BestelItem> GetMenuItemsByBestellingId(int bestelId)
        {
            string com = "SELECT *" +
                        " FROM Bestel_Item" +
                        " FULL OUTER JOIN Menu_Item ON Bestel_Item.Menu_Item_ID = Menu_Item.ID" +
                        " FULL OUTER JOIN Bestelling ON Bestelling.ID = Bestel_Item.Bestel_ID" +
                        " FULL OUTER JOIN Menu_Categorie ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.ID" +
                        " FULL OUTER JOIN Menu_Kaart ON Menu_Categorie.Menu_Kaart_ID = Menu_Kaart.ID" +
                        " FULL OUTER JOIN Tafel ON Bestelling.Tafel_ID = Tafel.ID" +
                        " FULL OUTER JOIN Medewerker ON Bestelling.Medewerker_ID = Medewerker.ID" +
                        " WHERE Bestel_Item.Bestel_ID =@bestelId AND Bestelling.Betaald=0";

            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@bestelId", bestelId);
            conn.Open();
            SqlDataReader reader = c.ExecuteReader();
            List<BestelItem> items = new List<BestelItem>();


            while (reader.Read())
            {
                BestelItem bestelItem = ReadBestelItem(reader);
                items.Add(bestelItem);
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

        public bool InsertBestelItem(BestelItem bestelitem)
        {
            try
            {
                string com = "INSERT INTO Bestel_Item (Bestel_ID, Menu_Item_ID, Aantal, Status, Opmerking, Prijs, DatumTijd)" +
                                " VALUES (@bestid, @menuId, @aantal, @status, @opmerking, @prijs, @datumtijd)";
                SqlCommand command = new SqlCommand(com, conn);

                command.Parameters.AddWithValue("@bestid", bestelitem.bestelling.ID);
                command.Parameters.AddWithValue("@menuId", bestelitem.item.id);
                command.Parameters.AddWithValue("@aantal", bestelitem.aantal);
                command.Parameters.AddWithValue("@status", bestelitem.status.ToString());
                command.Parameters.AddWithValue("@opmerking", bestelitem.opmerking);
                command.Parameters.AddWithValue("@prijs", bestelitem.prijs);
                command.Parameters.AddWithValue("@datumtijd", bestelitem.tijd);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                    return false; }
            finally
            {
                conn.Close();
            }
        }

        // Julian Remmers
        public List<BestelItem> GetForTable(int tafelId)
        {
            List<BestelItem> bestelitemlist = new List<BestelItem>();

            string query = "SELECT *" +
                        " FROM Bestel_Item" +
                        " FULL OUTER JOIN Menu_Item ON Bestel_Item.Menu_Item_ID = Menu_Item.ID" +
                        " FULL OUTER JOIN Bestelling ON Bestelling.ID = Bestel_Item.Bestel_ID" +
                        " FULL OUTER JOIN Menu_Categorie ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.ID" +
                        " FULL OUTER JOIN Menu_Kaart ON Menu_Categorie.Menu_Kaart_ID = Menu_Kaart.ID" +
                        " FULL OUTER JOIN Tafel ON Bestelling.Tafel_ID = Tafel.ID" +
                        " FULL OUTER JOIN Medewerker ON Bestelling.Medewerker_ID = Medewerker.ID" +
                        " WHERE Tafel.id = " + tafelId + "AND Bestelling.Betaald = 0";

            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                BestelItem item = ReadBestelItem(reader);
                bestelitemlist.Add(item);
            }

            reader.Close();
            conn.Close();

            return bestelitemlist;
        }
    }
}