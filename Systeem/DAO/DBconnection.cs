using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Systeem.DAO
{
    public class DBconnection
    {
        // Database connectie wordt geïnitialiseerd
        protected SqlConnection conn;

        // Constructor
        public DBconnection()
        {
            string connString = ConfigurationManager
                    .ConnectionStrings["ReserveringenConnectionStringSQL"]
                    .ConnectionString;

            // Database connectie wordt gelegd
            conn = new SqlConnection(connString);

        }

        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
