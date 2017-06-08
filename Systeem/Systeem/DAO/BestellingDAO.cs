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
        public BestelItem ReamMBestelItem(SqlDataReader reader)
        {
            int bestellingID = (int)reader["ID"];
            string status = (string)reader["Status"];
            int tafelid = (int)reader["Tafel_ID"];
            int Medewerker_ID = (int)reader["Medwerker_ID"];
            DateTime tijd = (DateTime)reader["DatumTijd"]; 


        }

        public List<Bestelling> GetAllBestellingen(string menukaart)
        {
            List<Bestelling> bestelling = new List<Bestelling>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling ='", conn);
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

