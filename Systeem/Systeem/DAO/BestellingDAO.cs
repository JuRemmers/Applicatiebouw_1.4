using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

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
        public Bestelling ReadBestelItem(SqlDataReader reader)
        {
            Status enumstatus = Status.Gereed;

            int bestellingID = (int)reader["ID"];
            string status = (string)reader["Status"];
            int tafelid = (int)reader["Tafel_ID"];
            int Medewerker_ID = (int)reader["Medewerker_ID"];
            DateTime tijd = (DateTime)reader["DatumTijd"];

            Tafel tafel = new Tafel(tafelid, true);
            Medewerker medewerker = new Medewerker(Medewerker_ID, "naam");

            switch(status)
            {
                case "Opgenomen":
                enumstatus = Status.Opgenomen;
                break;

                case "Gereed":
                    enumstatus = Status.Gereed;
                    break;

                case "Onderhande":
                    enumstatus = Status.Onderhande;
                    break;

                case "Uitgeserveerd":
                    enumstatus = Status.Uitgeserveerd;
                    break;
            }




            return new Bestelling(bestellingID, enumstatus, tafel, medewerker);

        }

        public List<Bestelling> GetAllBestellingen(string menukaart)
        {
            List<Bestelling> bestelling = new List<Bestelling>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling INNER JOIN Bestel_Item ON Bestelling.ID = Bestel_Item.Bestel_ID INNER JOIN  Menu_Item ON Bestel_Item.Menu_Item_ID = Menu_Item.ID", conn);
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
    }
}

