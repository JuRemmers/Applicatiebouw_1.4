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

        public Medewerker ReadMedewerker(SqlDataReader reader)
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

        // Kayleigh
        public Medewerker GetMedewerkerByBestellingId(int id)
        {
            string com = "SELECT Medewerker_ID FROM Bestelling WHERE ID=@id";
            SqlCommand c = new SqlCommand(com, conn);
            c.Parameters.AddWithValue("@id", id);
            conn.Open();
            int medId = (int)c.ExecuteScalar();

            com = "SELECT Voornaam FROM Medewerker WHERE ID=@id";
            c = new SqlCommand(com, conn);
            string medNaam = c.ExecuteScalar().ToString();

            Medewerker m = new Medewerker(medId, medNaam);
            return m;
        }
    }
}
