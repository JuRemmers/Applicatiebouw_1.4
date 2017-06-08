using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Systeem.DAO;

namespace Systeem.Logica
{
    class BestellingService
    {
        public List<Bestelling> GetAllForBestelling(string locatieid)
        {
            BestelItemDAO BestelDAL = new BestelItemDAO();
            List<Bestelling> Bestellingen = BestelDAL.GetAllBestellingen(locatieid);
            return Bestellingen;
        }
    }
}
