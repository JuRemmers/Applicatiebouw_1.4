using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Logica
{
    public class Kaartservice
    {
        MenuItemDAO MenuDal = new MenuItemDAO();
        
        // Donna vd Bent
        public List<MenuItem> GetAllkaart(string kaartid)
        {
            List<MenuItem> kaart = MenuDal.GetAllForKaart(kaartid);
            return kaart;
        }
    }
}
