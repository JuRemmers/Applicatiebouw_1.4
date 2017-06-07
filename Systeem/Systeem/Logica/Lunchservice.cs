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
            kaart.Add(new MenuItem(2, 3, 50, new Menucategorie(1,2, new MenuKaart(1,3)), new MenuKaart(1,3)));
            kaart.Add(new MenuItem(4, 3, 50, new Menucategorie(1, 2, new MenuKaart(8, 3)), new MenuKaart(1, 3)));
            return kaart;
        }
    }
}
