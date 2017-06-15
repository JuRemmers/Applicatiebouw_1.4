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
        public Bestelling ReadBestelItem(SqlDataReader reader)
        {
            Status enumstatus = Status.Gereed;

            int bestellingID = (int)reader["ID"];
            int tafelid = (int)reader["Tafel_ID"];
            int Medewerker_ID = (int)reader["Medewerker_ID"];

            Tafel tafel = new Tafel(tafelid, true);
            Medewerker medewerker = new Medewerker(Medewerker_ID, "naam");

            //switch (status)
            //{
            //    case "Opgenomen":
            //        enumstatus = Status.Opgenomen;
            //        break;

            //    case "Gereed":
            //        enumstatus = Status.Gereed;
            //        break;

            //    case "Onderhande":
            //        enumstatus = Status.Onderhande;
            //        break;

            //    case "Uitgeserveerd":
            //        enumstatus = Status.Uitgeserveerd;
            //        break;
            //}



            return new Bestelling(bestellingID, tafel, medewerker);

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

            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling INNER JOIN Bestel_Item ON Bestelling.ID = Bestel_Item.Bestel_ID INNER JOIN  Menu_Item ON Bestel_Item.Menu_Item_ID = Menu_Item.ID INNER JOIN Menu_Categorie ON Menu_Item.Menu_Categorie_ID = Menu_Categorie.ID INNER JOIN Menu_Kaart ON Menu_Categorie.Menu_Kaart_ID = Menu_Kaart.ID WHERE Menu_Kaart.ID = " + checkid, conn);
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
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling ", conn);
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

        // Kayleigh
        public int GetBestelIdByTafelId(int tafelId)
        {
            string com = "SELECT ID FROM Bestelling WHERE Tafel_ID=@id AND Betaald=0";
            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", tafelId);
            int bestId = 0;
            conn.Open();
            var scalar = c.ExecuteScalar();
            if (scalar == null)
            {
                return 0;
            }
            bestId = Convert.ToInt32(scalar);
            conn.Close();
            return bestId;
        }

        // Kayleigh
        public void UpdateBetaald(int bestelId)
        {
            string com = "UPDATE Bestelling SET Betaald=True WHERE ID=@id";
            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", bestelId);
            conn.Open();
            c.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateBestelling(int bestellingid, Status updatestatus)
        {           
            string stringstatus = updatestatus.ToString();
            SqlCommand command = new SqlCommand ("UPDATE Bestelling SET Status = @st WHERE Bestelling.ID = @id" , conn);
            command.Parameters.AddWithValue("@id", bestellingid);
            command.Parameters.AddWithValue("@st", stringstatus);

            conn.Open();
            command.ExecuteNonQuery();

            conn.Close();
        }
    }
}

