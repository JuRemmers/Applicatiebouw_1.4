using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace Systeem.DAO
{

    //Gemaakt door Julian Remmers
    class TafelDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public TafelDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }

        public Tafel ReadTafel(SqlDataReader reader)
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
        //Haal de status van de tafels op
        public bool GetAllBezet(bool bezet)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tafel WHERE Bezet=" + bezet, conn);
            SqlDataReader reader = command.ExecuteReader();
            string result = ReadTafel(reader).ToString();


            if (result == "true")
            {
                bezet = true;
            }
            else
            {
                bezet = false;
            }

            return bezet;
        }

    }
}
