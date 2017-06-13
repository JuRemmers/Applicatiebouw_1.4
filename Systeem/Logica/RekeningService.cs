using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Logica
{
    public class RekeningService
    {
        const double BTWL = 0.06;
        const double BTWH = 0.21;

        public List<BestelItem> GetBestellingByTafelId(int id)
        {
            BestellingDAO d = new BestellingDAO();
            int bestelId = d.GetBestelIdByTafelId(id);
            
            BestelItemDAO b = new BestelItemDAO();
            List <BestelItem> bestelling = b.GetMenuItemsByBestellingId(bestelId);
            
            return bestelling;
        }



    }
}
