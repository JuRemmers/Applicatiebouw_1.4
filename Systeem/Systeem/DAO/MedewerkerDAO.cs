using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Systeem.DAO
{
    class MedewerkerDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public MedewerkerDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }
    }
}
