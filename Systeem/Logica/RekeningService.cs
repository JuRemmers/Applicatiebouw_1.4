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

        public Rekening MakeRekening(int TafelId, List<BestelItem> items)
        {
            BestellingDAO d = new BestellingDAO();
            int bestelId = d.GetBestelIdByTafelId(TafelId);

            
            MedewerkerDAO m = new MedewerkerDAO();
            Medewerker med = m.GetMedewerkerByBestellingId(bestelId);

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
            Rekening r = new Rekening(bestelId, btwl, btwh, prijs, fooi, totaalprijs, med, opm);
            return r;
        }



    }
}
