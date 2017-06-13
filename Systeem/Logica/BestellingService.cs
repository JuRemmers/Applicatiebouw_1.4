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
        List<Bestelling> bestelling = new List<Bestelling>();

        public void Add(string gerecht)
        {

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

        public void UpdateStatus(int bestellingid, Status updatestatus)
        {
            BestelDAL.UpdateBestelling(bestellingid, updatestatus);
        }
    }
}
