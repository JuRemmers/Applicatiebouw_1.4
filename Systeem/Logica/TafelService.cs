using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Logica
{
    public class TafelService
    {
        TafelDAO tafelDAL = new TafelDAO();
        BestelItemDAO bestelItemDAL = new BestelItemDAO();

        public bool TafelStatus(int id)
        {
            Tafel tafel = tafelDAL.GetForId(id);
            if (tafel.Bezet)
            {
                return true;
            }
            else return false;
        }

        public void UpdateStatus(int id, bool status)
        {
            tafelDAL.UpdateStatus(id, status);
        }

        public string GetGerechtStatus(int tafelId)
        {
            List<BestelItem> bestelitem = bestelItemDAL.GetForTable(tafelId);
            List<Status> statuslist = new List<Status>();

            foreach (BestelItem item in bestelitem)
            {
                if (item == null)
                {
                    statuslist.Add(Status.Null);
                }
                else statuslist.Add(item.status);
            }

            if (statuslist.Contains(Status.Gereed))
                return "gereed";

            else if (statuslist.Contains(Status.Onderhande))
                return "onderhande";

            else if (statuslist.Contains(Status.Opgenomen))
                return "opgenomen";

            else if (statuslist.Contains(Status.Uitgeserveerd))
                return "uitgeserveerd";

            else return null;
                        
            // Wat gaan we doen
            // 1. nieuwe methode servicelaag
            // 2. verander naam huidige methode
            // 3. 
        }
    }
}
