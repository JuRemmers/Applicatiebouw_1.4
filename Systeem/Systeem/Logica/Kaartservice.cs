using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Systeem.DAO;

namespace Systeem.Logica
{
    class Kaartservice
    {
        public List<MenuItem> GetAllkaart(string kaartid)
        {
            MenuItemDAO MenuDal = new MenuItemDAO();
            List<MenuItem> kaart = MenuDal.GetAllForKaart(kaartid); ;


            return kaart;
        }
    }
}
