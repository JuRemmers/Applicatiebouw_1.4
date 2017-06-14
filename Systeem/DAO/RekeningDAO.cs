using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

// Geschreven door Kayleigh Vossen

namespace DAO
{
    public class RekeningDAO
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
            SqlCommand c = new SqlCommand(com, conn);
            
            c.Parameters.AddWithValue("@btwl", r.btwLaag);
            c.Parameters.AddWithValue("@btwh", r.btwHoog);
            c.Parameters.AddWithValue("@prijs", r.Prijs);
            c.Parameters.AddWithValue("@fooi", r.fooi);
            c.Parameters.AddWithValue("@totaalprijs", r.totaalprijs);
            c.Parameters.AddWithValue("@datumtijd", r.datumtijd);
            c.Parameters.AddWithValue("@medid", r.medewerker.ID);
            c.Parameters.AddWithValue("@opm", r.opmerking);
            
            conn.Open();
            c.ExecuteNonQuery();
            conn.Close();
        }


        

    }
}