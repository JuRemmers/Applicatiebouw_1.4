using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

// Geschreven door Kayleigh Vossen
namespace Systeem.DAO
{
    class RekeningDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public RekeningDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }


        public void UpdateTip(int id, double fooi)
        {
            // maak de command aan
            string com = "UPDATE Rekening SET Fooi = @fooi  WHERE ID = @id";
            SqlCommand command = new SqlCommand(com, conn);

            // geef de parameters aan command mee
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fooi", fooi);

            // Voer command uit
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void GetTafelOverzicht(int tafelId)
        {
            string com = "SELECT Bestelling WHERE Tafel_ID=@id ";
            SqlCommand command = new SqlCommand(com);
            command.Parameters.AddWithValue("@id", tafelId);
            conn.Open();

        }

        public void MakeRekening(int bestelId, double btwL, double btwH, double prijs, double fooi, DateTime datumtijd, int medewerkerId, bool betaald, string oppmerking)
        {
            // maak de command aan
            string com = "INSERT INTO Rekening VALUES @bestelId, @btwL, @btwH, @prijs, @fooi, @datumtijd, @medewerkerId, @betaald, @opmerking";
            SqlCommand command = new SqlCommand(com);

            // geef de parameters mee aan het command
            command.Parameters.AddWithValue("@bestelId", bestelId);
            command.Parameters.AddWithValue("@btwL", btwL);
            command.Parameters.AddWithValue("@btwH", btwH);
            command.Parameters.AddWithValue("@prijs", prijs);
            command.Parameters.AddWithValue("@fooi", fooi);
            command.Parameters.AddWithValue("@datumtijd", datumtijd);
            command.Parameters.AddWithValue("@medewerkerId", medewerkerId);
            command.Parameters.AddWithValue("@opmerking", oppmerking);

            // voer command uit
            conn.Open();
            command.ExecuteScalar();
            conn.Close();

        }

        public Rekening GetRekeningById(int rekeningId)
        {
            Rekening r;
            // maak command
            string com = "SELECT Rekening WHERE ID=@id";
            SqlCommand command = new SqlCommand(com);
            SqlDataReader reader = command.ExecuteReader();

            // voeg parameters toe
            command.Parameters.AddWithValue("@id", rekeningId);
            conn.Open();

            return r;
        }

        public void GetAll()
        {

        }

        public void GetAllForBetaald()
        {

        }

        public void GetAllForOpen()
        {

        }

        public void GetForTafelId()
        {

        }

        public void GetForId()
        {

        }

        public void GetForDatum()
        {

        }

        public void GetForMedewerkerId()
        {

        }
    }
}