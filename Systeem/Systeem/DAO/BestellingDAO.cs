using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Systeem.Model;

namespace Systeem.DAO
{
    class BestellingDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public BestellingDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }
        public List<Bestelling> GetAllBestellingen(string menukaart)
        {
            List<Bestelling> bestelling = new List<Bestelling>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT Menu_Item.ID, Gerecht, Prijs, Voorraad, Menu_Categorie_ID as categorieID, Menu_Categorie.Categorie, Menu_Categorie.btw, Menu_Categorie.Menu_Kaart_ID, Menu_Kaart.id as menuKaartID, Menu_Kaart.Kaart FROM Menu_Item INNER JOIN Menu_Categorie ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.id INNER JOIN Menu_Kaart on Menu_Categorie.Menu_Kaart_ID = Menu_Kaart.id WHERE Menu_Kaart.Kaart='" + menukaart + "'", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Bestelling item = ReadMenuItem(reader);
                bestelling.Add(item);
            }

            reader.Close();
            conn.Close();

            return bestelling;
        }
    }
}

