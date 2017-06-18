using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAO
{
    public class BestellingDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public BestellingDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }
        private Bestelling ReadBestelItem(SqlDataReader reader)
        {
            try
            {
                while (reader.Read())
                {
                    int bestellingID = (int)reader["ID"];
                    int tafelid = (int)reader["Tafel_ID"];
                    int medewerkerid = (int)reader["Medewerker_ID"];
                    Tafel tafel = new Tafel(tafelid, true);
                    Medewerker medewerker = new Medewerker(medewerkerid, "naam", "achternaam", Functie.Bar, "password");
                    return new Bestelling(bestellingID, true, tafel, medewerker);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public List<Bestelling> GetAllBestellingen(string locatieid)
        {
            int checkid;
            List<Bestelling> bestelling = new List<Bestelling>();

            conn.Open();

            if (locatieid == "Bar")
            {
                checkid = 1;
            }
            else
            {
                checkid = 2;
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling INNER JOIN Bestel_Item ON Bestelling.ID = Bestel_Item.Bestel_ID INNER JOIN  Menu_Item ON Bestel_Item.Menu_Item_ID = Menu_Item.ID INNER JOIN Menu_Categorie ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.ID INNER JOIN Menu_Kaart ON Menu_Categorie.Menu_Kaart_ID = Menu_Kaart.ID WHERE Menu_Kaart.ID = @id AND Bestelling.Betaald = 0", conn);
            command.Parameters.AddWithValue("@id", checkid);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Bestelling item = ReadBestelItem(reader);
                bestelling.Add(item);
            }

            reader.Close();
            conn.Close();

            return bestelling;
        }

        public List<Bestelling> GetAllBestellingenAlles()
        {
            conn.Open();

            List<Bestelling> bestellingalles = new List<Bestelling>();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling WHERE Betaald = 0", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Bestelling item = ReadBestelItem(reader);
                bestellingalles.Add(item);
            }

            reader.Close();
            conn.Close();

            return bestellingalles;
        }

        // Kayleigh Vossen
        public Bestelling GetBestellingByTafelId(int tafelId)
        {
            string com = "SELECT *" +
                            " FROM Bestelling" +
                            " FULL OUTER JOIN Tafel" +
                            " ON Bestelling.Tafel_ID=Tafel.ID" +
                            " FULL OUTER JOIN Medewerker" +
                            " ON Bestelling.Medewerker_ID=Medewerker.ID" +
                            " WHERE Tafel_ID=@id AND Betaald=0";
            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", tafelId);
            conn.Open();
            SqlDataReader reader = c.ExecuteReader();
            int bestelID = 0;
            int MedewerkerID = 0;
            bool Betaald = false;
            bool Bezet = true;
            string voornaam = "";
            string achternaam = "";
            Functie functie = Functie.Bar;
            string wachtwoord = "";


            while (reader.Read())
            {
                bestelID = reader.GetInt32(0);
                MedewerkerID = reader.GetInt32(2);
                Betaald = reader.GetBoolean(3);
                Bezet = reader.GetBoolean(5);
                voornaam = reader.GetString(7);
                achternaam = reader.GetString(8);
                functie = (Functie)Enum.Parse(typeof(Functie), reader.GetString(9));
                wachtwoord = reader.GetString(10);
            }
            conn.Close();
            Medewerker m = new Medewerker(MedewerkerID, voornaam, achternaam, functie, wachtwoord);
            Tafel t = new Tafel(tafelId, Bezet);
            return new Bestelling(bestelID,Betaald,t,m);
        }

        // Kayleigh
        public void UpdateBetaald(int bestelId)
        {
            string com = "UPDATE Bestelling SET Betaald=1 WHERE ID=@id";
            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", bestelId);
            conn.Open();
            c.ExecuteNonQuery();
            conn.Close();
        }

        public Bestelling NewBestelling(int tafel, int medewerkerId)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Bestelling(Tafel_ID, Medewerker_ID, betaald) VALUES(" + tafel + ", " + medewerkerId + ", 'false')", conn);
            
            command.ExecuteNonQuery();
            conn.Close();

            return GetBestelling(medewerkerId, tafel);
        }

        public Bestelling GetBestelling(int medewerkerid, int tafelid, bool betaald = false)
        {
            int check;
            if (betaald)
                check =1;
            else { check = 0; }
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling WHERE Medewerker_ID=" + medewerkerid + " AND Tafel_ID=" + tafelid + " AND Betaald =" + check, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            Bestelling bestelling = ReadBestelItem(reader);

            conn.Close();
            reader.Close();
            return bestelling;
        }
    }
}

