using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systeem.Model;
using Systeem.DAO;

namespace Systeem.Logica
{
    class Lunchservice
    {

        public List<MenuItem> GetAllkaart(string kaartid)
        {
            MenuItemDAO MenuDal = new MenuItemDAO();
            List<MenuItem> kaart = new List<MenuItem>();

            return kaart;
        }
    }
}
