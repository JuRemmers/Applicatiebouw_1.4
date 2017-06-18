using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAO
{
    public class MenuItemDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public MenuItemDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }

        private MenuItem ReadMenuItem(SqlDataReader reader)
        {
            try
            {
                int menuitemID = (int)reader["ID"];
                string gerecht = (string)reader["Gerecht"];
                double prijs = (double)reader["Prijs"];
                int voorraad = (int)reader["Voorraad"];

                int categorieid = (int)reader["categorieID"];
                string categorie = (string)reader["Categorie"];
                int btw = (int)reader["btw"];
                int menukaart_id = (int)reader["menuKaartID"];
                string naam = (string)reader["Kaart"];

                Menucategorie cAtegorie = new Menucategorie(categorieid, categorie, btw, new MenuKaart(menukaart_id, naam));
                return new MenuItem(menuitemID, gerecht, prijs, voorraad, cAtegorie);
            }
            catch
            { return null; }
        }

        // Donna vd Bent
        public List<MenuItem> GetAllForKaart(string menukaart)
        {
            List<MenuItem> menuitems = new List<MenuItem>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT Menu_Item.ID, Gerecht, Prijs, Voorraad, Menu_Categorie_ID as categorieID, Menu_Categorie.Categorie, Menu_Categorie.btw, Menu_Categorie.Menu_Kaart_ID, Menu_Kaart.id as menuKaartID, Menu_Kaart.Kaart FROM Menu_Item INNER JOIN Menu_Categorie ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.id INNER JOIN Menu_Kaart on Menu_Categorie.Menu_Kaart_ID = Menu_Kaart.id WHERE Menu_Kaart.Kaart='" + menukaart + "'", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MenuItem item = ReadMenuItem(reader);
                menuitems.Add(item);
            }

            reader.Close();
            conn.Close();

            return menuitems;
        }

        public MenuItem GetForGerecht(string gerecht)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT Menu_Item.ID, Gerecht, Prijs, Voorraad, Menu_Categorie_ID as categorieID, Menu_Categorie.Categorie, Menu_Categorie.btw, Menu_Categorie.Menu_Kaart_ID, Menu_Kaart.id as menuKaartID, Menu_Kaart.Kaart FROM Menu_Item INNER JOIN Menu_Categorie ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.id INNER JOIN Menu_Kaart on Menu_Categorie.Menu_Kaart_ID = Menu_Kaart.id WHERE Gerecht='" + gerecht + "'", conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            MenuItem item = ReadMenuItem(reader);

            reader.Close();
            conn.Close();

            return item;
        }
    }
}
