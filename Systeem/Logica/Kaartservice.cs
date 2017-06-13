using System.Collections.Generic;
using Model;
using DAO;

namespace Systeem.Logica
{
    public class Kaartservice
    {
        public List<MenuItem> GetAllkaart(string kaartid)
        {
            MenuItemDAO MenuDal = new MenuItemDAO();
            List<MenuItem> kaart = MenuDal.GetAllForKaart(kaartid);
            return kaart;
        }
    }
}
