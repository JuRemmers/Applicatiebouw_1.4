using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAO
{
    public class MedewerkerDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public MedewerkerDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }

        private Medewerker ReadMedewerker(SqlDataReader reader)
        {
            try
            {
                int id = (int)reader["ID"];
                string voornaam = (string)reader["Voornaam"];
                string achternaam = (string)reader["Achternaam"];
                string functie = (string)reader["Functie"];
                string wachtwoord = (string)reader["Wachtwoord"];

                Functie fun;
                switch (functie)
                {
                    case "Bar":
                        { fun = Functie.Bar; break; }
                    case "Bediening":
                        { fun = Functie.Bediening; break; }
                    case "Keuken":
                        { fun = Functie.Keuken; break; }
                    case "Beheer":
                        { fun = Functie.Beheer; break; }
                    default:
                        { fun = Functie.Bediening; break; }
                }
                return new Medewerker(id, voornaam, achternaam, fun, wachtwoord);
            }
            catch
            { return null; }
        }

        // Jesse van Duijne
        public Medewerker GetForID(int id)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Medewerker WHERE ID=" + id, conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Medewerker medewerker = ReadMedewerker(reader);

            reader.Close();
            conn.Close();

            return medewerker;
        }
    }
}
