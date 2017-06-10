﻿using System;
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

        public Rekening GetTafelOverzichtByTafelId(int tafelId)
        {
            string com = "SELECT ID,Bestelling FROM Rekening WHERE Tafel_ID=@id ";
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

        public void MakeRekening(Rekening r)
        {
            string com = "INSERT INTO Rekening VALUES @bestelId, @btwL, @btwH, @prijs, @fooi, @datumtijd, @medewerkerId, @betaald, @opmerking";
            SqlCommand command = new SqlCommand(com);

            // geef de parameters mee aan het command
            command.Parameters.AddWithValue("@bestelId", r.bestelling.ID);
            command.Parameters.AddWithValue("@btwL", r.btwLaag);
            command.Parameters.AddWithValue("@btwH", r.btwHoog);
            command.Parameters.AddWithValue("@prijs", r.totaalPrijs);
            command.Parameters.AddWithValue("@fooi", r.fooi);
            command.Parameters.AddWithValue("@datumtijd", DateTime.Now);
            command.Parameters.AddWithValue("@medewerkerId", r.medewerker);
            command.Parameters.AddWithValue("@opmerking", r.opmerking);

            // voer command uit
            conn.Open();
            command.ExecuteScalar();
            conn.Close();
        }

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

            Rekening r = new Rekening(rekeningId, new Bestelling(bestelId), btwL, btwH, prijs, fooi, dt, new Medewerker(medId), betaald, opmerking);

            return r;
        }

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

            Rekening rekening = new Rekening(id, new Bestelling(bestelId), btwL, btwH, prijs, fooi, dt, new Medewerker(medId), betaald, opmerking);

            return rekening;
        }
    }
}