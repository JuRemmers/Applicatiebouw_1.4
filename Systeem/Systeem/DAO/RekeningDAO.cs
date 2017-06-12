using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using Systeem.Logica;

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

        public void InsertRekening(Rekening r)
        {
            string com = "INSERT INTO Rekening VALUES @bestId,@btwl,@btwh,@prijs,@fooi,@totaalprijs,@datumtijd,@medid,@opm";
        }

        // Maakt rekening aan met bestelID en medewerkerID
        public void MakeTafelOverzicht(int tafelId)
        {
            string com = "SELECT ID,Medewerker_ID FROM Bestelling WHERE Tafel_ID=@id";
            SqlCommand c = new SqlCommand(com, conn);
            SqlDataReader reader = c.ExecuteReader();
            c.Parameters.AddWithValue("@tafelId", tafelId);
            conn.Open();
            int bestelId = 0;
            int medId = 0;

            while (reader.Read())
            {
                bestelId = reader.GetInt32(0);
                medId = reader.GetInt32(1);
            }

            com = "INSERT INTO Rekening(Bestel_ID,Medewerker_ID) VALUES(@bestelId,@medId)";
            c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@bestelId", bestelId);
            c.Parameters.AddWithValue("@medId", medId);
            c.ExecuteNonQuery();
            conn.Close();            
        }

        // returned rekening met bestelID
        public Rekening GetTafelOverzichtByTafelId(int tafelId)
        {
            string com = "SELECT ID,Bestel_ID FROM Rekening WHERE Tafel_ID=@id ";
            SqlCommand command = new SqlCommand(com);
            command.Parameters.AddWithValue("@id", tafelId);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            int id = 0;
            int bestellingId = 0;

            while (reader.Read())
            {
                id = reader.GetInt32(0);
                bestellingId = reader.GetInt32(1);
            }

            conn.Close();

            Rekening r = new Rekening(id, new Bestelling(bestellingId));
            return r;

        }

        // update rekening met prijzen, wordt op 1 plek in UI aangeroepen!
        public void UpdateRekening(Rekening r)
        {
            string com = "UPDATE Rekening SET BTW_Laag=@btwL, BTW_Hoog=@btwH, Prijs=@prijs, Fooi=@fooi, DatumTijd=@datumtijd, Medewerker_ID=@medewerkerId, Betaald=@betaald, Opmerking=@opmerking WHERE ID=id";
            SqlCommand command = new SqlCommand(com);

            // geef de parameters mee aan het command
            command.Parameters.AddWithValue("@btwL", r.btwLaag);
            command.Parameters.AddWithValue("@btwH", r.btwHoog);
            command.Parameters.AddWithValue("@prijs", r.Prijs);
            command.Parameters.AddWithValue("@fooi", r.fooi);
            command.Parameters.AddWithValue("@datumtijd", r.datumTijd);
            command.Parameters.AddWithValue("@medewerkerId", r.medewerker);
            command.Parameters.AddWithValue("@opmerking", r.opmerking);
            command.Parameters.AddWithValue("@id", r.Id);

            // voer command uit
            conn.Open();
            command.ExecuteScalar();
            conn.Close();
        }
        
        // returned rekening met prijzen etc.
        public Rekening GetRekeningByRekeningId(int rekeningId)
        {
            // maak command
            string com = "SELECT * FROM Rekening WHERE ID=@id";
            SqlCommand command = new SqlCommand(com);
            SqlDataReader reader = command.ExecuteReader();

            int bestelId = 0;
            double btwL = 0;
            double btwH = 0;
            double prijs = 0;
            double fooi = 0;
            DateTime dt = DateTime.Now;
            int medId = 0;
            bool betaald = false;
            string opmerking = "";

            // voeg parameters toe
            command.Parameters.AddWithValue("@id", rekeningId);
            conn.Open();

            while (reader.Read())
            {
                btwL = reader.GetDouble(2);
                btwH = reader.GetDouble(3);
                prijs = reader.GetDouble(4);
                fooi = reader.GetDouble(5);
                dt = reader.GetDateTime(6);
                medId = reader.GetInt32(7);
                betaald = reader.GetBoolean(8);
                opmerking = reader.GetString(9);
            }
            conn.Close();

            Rekening r = new Rekening(rekeningId, new Bestelling(bestelId), btwL, btwH, prijs, fooi, dt, new Medewerker(medId, "naam"), betaald, opmerking);

            return r;
        }
        
        // ?? overbodig maybe
        public Rekening GetRekeningByBestelId(int bestelId)
        {
            // maak command
            string com = "SELECT * FROM Rekening WHERE Bestel_ID=@id";
            SqlCommand command = new SqlCommand(com);
            SqlDataReader reader = command.ExecuteReader();

            int id = 0;
            double btwL = 0;
            double btwH = 0;
            double prijs = 0;
            double fooi = 0;
            DateTime dt = DateTime.Now;
            int medId = 0;
            bool betaald = false;
            string opmerking = "";

            // voeg parameters toe
            command.Parameters.AddWithValue("@id", bestelId);
            conn.Open();

            while (reader.Read())
            {
                id = reader.GetInt32(0);
                btwL = reader.GetDouble(2);
                btwH = reader.GetDouble(3);
                prijs = reader.GetDouble(4);
                fooi = reader.GetDouble(5);
                dt = reader.GetDateTime(6);
                medId = reader.GetInt32(7);
                betaald = reader.GetBoolean(8);
                opmerking = reader.GetString(9);
            }
            conn.Close();

            Rekening rekening = new Rekening(id, new Bestelling(bestelId), btwL, btwH, prijs, fooi, dt, new Medewerker(medId, "naam"), betaald, opmerking);

            return rekening;
        }

        // update fooi
        public void UpdateTip(double tip, int Id)
        {
            // maak de command aan
            string com = "UPDATE Rekening SET Fooi = @fooi  WHERE ID = @id";
            SqlCommand command = new SqlCommand(com, conn);

            // geef de parameters aan command mee
            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@fooi", tip);

            // Voer command uit
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        // update betaald status
        public void UpdateBetaald(int Id)
        {
            string com = "UPDATE Rekening SET Betaald=true WHERE ID=@id";
            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", Id);

            conn.Open();
            c.ExecuteNonQuery();
            conn.Close();
        }

        // update opmerken
        public void UpdateOpmerking(string opm, int id)
        {
            string com = "UPDATE Rekening SET Opmerking=@opm WHERE ID=@id";
            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", id);

            conn.Open();
            c.ExecuteNonQuery();
            conn.Close();
        }

    }
}