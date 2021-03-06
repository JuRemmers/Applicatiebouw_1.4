﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAO
{

    //Gemaakt door Julian Remmers
    public class TafelDAO
    {
        protected SqlConnection conn; // Algemeen verbinding leggen met DB
        protected DBconnection dbconn; // Methode om in te loggen

        public TafelDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }

        private Tafel ReadTafel(SqlDataReader reader)
        {
            try
            {
                int id = (int)reader["id"];
                bool bezet = (bool)reader["bezet"];

                return new Tafel(id, bezet);
            }
            catch
            {
                return null;
            }
        }

        //Haal alle tafels op
        public List<Tafel> GetAll()
        {
            List<Tafel> tafels = new List<Tafel>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Tafel", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Tafel tafel = ReadTafel(reader);
                tafels.Add(tafel);
            }

            reader.Close();
            conn.Close();

            return tafels;
        }

        //Haal de ID voor de tafels op
        public Tafel GetForId(int id)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Tafel WHERE ID=" + id, conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Tafel tafel = ReadTafel(reader);

            reader.Close();
            conn.Close();

            return tafel;
        }

        // Jesse van Duijne
        public void UpdateStatus(int id, bool status)
        {
            SqlCommand c = new SqlCommand("UPDATE Tafel SET Bezet ='" + status.ToString() + "' WHERE ID =" + id, conn); // Enkele haakjes want varchar (hierom geen parameters)

            conn.Open();
            c.ExecuteNonQuery();
            conn.Close();
        }

    }
}
