using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Systeem.DAO
{
    class BestelItemDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;
        // hai

        public BestelItemDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }
    }
}
