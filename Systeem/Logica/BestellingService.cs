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
            if (item == null || item.voorraad <= 0)
            { return false; }

            BestelItem bestelitem = new BestelItem(item, aantal);

            bool dubbel = false;
            foreach (BestelItem bestel_item in bestelling)
            {
                dubbel = bestel_item.Compare(bestelitem);
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
            List<BestelItem>bestelling = bestelItemDAL.GetBestellingItemsByBestellingId(bestelId);
            return bestelling;
        }
    }
}
