using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Systeem.Model;

namespace Systeem.DAO
{
    class MenuItemDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public MenuItemDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }

        public List<MenuItem> GetAllkaart()
            {
                
            }
    }
}
