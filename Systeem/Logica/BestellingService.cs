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
        public List<Bestelling> GetAllForBestelling(string locatieid)
        {
            BestellingDAO BestelDAL = new BestellingDAO();
            List<Bestelling> Bestellingen = BestelDAL.GetAllBestellingen(locatieid);
            return Bestellingen;
        }

        public List<Bestelling> GetAllForBestellingAlles()
        {
            BestellingDAO BestelDAL = new BestellingDAO();
            List<Bestelling> Bestellingen = BestelDAL.GetAllBestellingenAlles();
            return Bestellingen;
        }
    }
}
