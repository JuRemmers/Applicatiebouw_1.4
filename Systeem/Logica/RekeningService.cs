using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

// Kayleigh Vossen
namespace Logica
{
    public class RekeningService
    {
        const double BTWL = 0.06;
        const double BTWH = 0.21;

        public List<BestelItem> GetBestellingByTafelId(int id)
        {
            BestellingDAO d = new BestellingDAO();
            Bestelling best = d.GetBestellingByTafelId(id);
            
            BestelItemDAO b = new BestelItemDAO();
            List <BestelItem> bestelling = b.GetMenuItemsByBestellingId(best.ID);
            
            return bestelling;
        }

        public Rekening MakeRekening(int TafelId, List<BestelItem> items)
        {
            BestellingDAO d = new BestellingDAO();
            Bestelling b = d.GetBestellingByTafelId(TafelId);


            double prijs = 0;
            double btwl = 0;
            double btwh = 0;

            foreach(BestelItem i in items)
            {
                double productprijs = i.aantal * i.item.prijs;
                prijs += productprijs;

                if (i.item.Categorie.btw == 6)
                    btwl += productprijs * BTWL;
                else if (i.item.Categorie.btw == 21)
                    btwh += productprijs * BTWH;
            }

            double fooi = 0;
            double totaalprijs = prijs + fooi;
            string opm = "";
            Rekening r = new Rekening(b, btwl, btwh, prijs, fooi, totaalprijs, items[0].bestelling.medewerker, opm);
            return r;
        }



    }
}
