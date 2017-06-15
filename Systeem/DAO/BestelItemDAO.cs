﻿using System;
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
            string com = "SELECT *" +
                            " FROM Bestel_Item" +
                            " FULL OUTER JOIN Menu_Item ON Bestel_Item.Menu_Item_ID = Menu_Item.ID" +
                            " FULL OUTER JOIN Bestelling ON Bestelling.ID = Bestel_Item.Bestel_ID" +
                            " FULL OUTER JOIN Menu_Categorie ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.ID" +
                            " WHERE Bestel_Item.Bestel_ID = 1 AND Bestel_Item.Betaald=0";

            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", bestelId);
            conn.Open();
            SqlDataReader reader = c.ExecuteReader();
            List<BestelItem> items = new List<BestelItem>();

            
            while (reader.Read())
            {
                int BestelItemID = reader.GetInt32(0);
                int menuItemID = reader.GetInt32(2);
                int aantal = reader.GetInt32(3);
                Status status = (Status) Enum.Parse(typeof(Status),reader.GetString(4));
                string opmerking = reader.GetString(5);
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
                Functie functie = (Functie) Enum.Parse(typeof(Functie), reader.GetString(28));
                string wachtwoord = reader.GetString(29);

                Menucategorie cat = new Menucategorie(MenuCatId, menuCatNaam, btw, MenuKaartId);
                MenuKaart kaart = new MenuKaart(MenuKaartId, menukaartNaam);
                MenuItem menuitem = new MenuItem(menuItemID, MenuItemNaam, MenuItemPrijs, MenuItemVoorraad, cat, kaart);
                Tafel tafel = new Tafel(tafelId, tafelstatus);
                Medewerker med = new Medewerker(medId, voornaam, achternaam, functie, wachtwoord);
                Bestelling best = new Bestelling(bestelId, betaald, tafel, med);
                BestelItem bestelItem = new BestelItem(BestelItemID,best,menuitem,BestelItemPrijs,aantal,status,opmerking,bestelItemTijd);
                items.Add(bestelItem);
            }
            conn.Close();
            return items;
        }
    }
}