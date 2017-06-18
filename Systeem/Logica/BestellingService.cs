using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Logica
{
    public class BestellingService
    {
        BestellingDAO BestelDAL = new BestellingDAO();
        BestelItemDAO bestelItemDAL = new BestelItemDAO();
        List<BestelItem> bestelling = new List<BestelItem>();
        MenuItemDAO menuItemDAL = new MenuItemDAO();

        public bool Add(string gerecht, int aantal)
        {
            MenuItem item = menuItemDAL.GetForGerecht(gerecht);

            // item = null als een categorie gekozen is
            // Kayleigh edit: ipv item.voorraad <= 0, want nu wordt ook een vraag naar 10 items afgekapt als er maar 9 zijn
            if (item == null || aantal > item.voorraad )
            { return false; }

            BestelItem bestelitem = new BestelItem(item, aantal);

            bool dubbel = false;
            foreach (BestelItem bestel_item in bestelling)
            {
                dubbel = bestel_item.Compare(bestelitem); // Compare > update ook het aantal
            }

            if (!dubbel)
            { bestelling.Add(bestelitem); }

            return true;
        }

        public List<Bestelling> GetAllForBestelling(string locatieid)
        {
            List<Bestelling> Bestellingen = BestelDAL.GetAllBestellingen(locatieid);
            return Bestellingen;
        }

        public List<Bestelling> GetAllForBestellingAlles()
        {
            List<Bestelling> Bestellingen = BestelDAL.GetAllBestellingenAlles();
            return Bestellingen;
        }

        public void UpdateStatus(int bestellingid, Status updatestatus, string gerecht)
        {
            bestelItemDAL.UpdateBestelitem(bestellingid, updatestatus, gerecht);
        }

        // Donna vd Bent
        public List<BestelItem> GetBestelling()
        {
            return bestelling;
        }

        public int GetCount()
        {
            int aantal = 0;

            foreach (BestelItem item in bestelling)
            {
                aantal = aantal + item.aantal;
            }

            return aantal;
        }

        public List<BestelItem> GetAllForItems(int bestelId)
        {
            List<BestelItem> bestelling = bestelItemDAL.GetMenuItemsByBestellingId(bestelId);
            return bestelling;
        }

        // Donna vd Bent
        public bool WijzigAantal(string item, int aantal)
        {
            foreach (BestelItem bestelItem in bestelling)
            {
                if (bestelItem.Vergelijk(item))
                {
                    bestelItem.WijzigAantal(aantal);
                    return true;
                }
            }
            return false;
        }

        // Donna vd Bent
        public bool Verwijder(string item)
        {
            foreach (BestelItem bestelitem in bestelling)
            {
                if (bestelitem.Vergelijk(item))
                {
                    bestelling.Remove(bestelitem);
                    return true;
                }
            }
            return false;
        }

        // Donna vd Bent
        public bool PlaatsBestelling(int medewerkerId, int tafelId)
        {
            if (bestelling.Count == 0)
                return false;

            Bestelling order = BestelDAL.GetBestelling(medewerkerId, tafelId);
            if (order == null)
            {  order = BestelDAL.NewBestelling(tafelId, medewerkerId);  }
            
            foreach (BestelItem bestelitem in bestelling)
            {

                MenuItem item = menuItemDAL.GetForGerecht(bestelitem.item.ToString());
                menuItemDAL.UpdateVoorraad(item.id, item.voorraad - bestelitem.aantal);

                bestelitem.SetBestelling(order);
                bestelitem.SetBestelId(order.ID);
                bestelitem.SetPrijs(item.prijs);
                bestelitem.SetMenuItem(item);

                if (!bestelItemDAL.InsertBestelItem(bestelitem))
                { return false; }
            }

            TafelService service = new TafelService();
            service.UpdateStatus(tafelId, true);

            bestelling.Clear();
            return true;
        }
    }
}
