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
        // constanten voor vaste waardes
        const double BTWL = 0.06;
        const double BTWH = 0.21;

        public List<BestelItem> GetBestellingByTafelId(int id)
        {
            // haalt de bestelling op bij opgegeven tafelId
            BestellingDAO d = new BestellingDAO();
            Bestelling best = d.GetBestellingByTafelId(id);
            
            // haalt de list<bestelItems> op bij opgegeven bestelId
            BestelItemDAO b = new BestelItemDAO();
            List <BestelItem> bestelling = b.GetMenuItemsByBestellingId(best.ID);
            
            return bestelling;
        }

        public Rekening MakeRekening(int TafelId, List<BestelItem> items)
        {
            // haalt de bestelling op bij tafelID
            BestellingDAO d = new BestellingDAO();
            Bestelling b = d.GetBestellingByTafelId(TafelId);


            double prijs = 0;
            double btwl = 0;
            double btwh = 0;

            // prijzen worden voor elk item in de lijst opgemaakt + btw waardes worden berekend
            foreach(BestelItem i in items)
            {
                double productprijs = i.aantal * i.item.prijs;
                prijs += productprijs;

                if (i.item.Categorie.btw == 6)
                    btwl += productprijs * BTWL;
                else if (i.item.Categorie.btw == 21)
                    btwh += productprijs * BTWH;
            }

            // fooi + opmerking blijven leeg tot medewerker dit aanpast.
            double fooi = 0;
            double totaalprijs = prijs + fooi;
            string opm = "";
            Rekening r = new Rekening(b, btwl, btwh, prijs, fooi, totaalprijs, items[0].bestelling.medewerker, opm);
            return r;
        }



    }
}
