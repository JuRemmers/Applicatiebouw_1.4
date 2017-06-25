using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Logica
{
    // Jesse van Duijne
    public class TafelService
    {
        TafelDAO tafelDAL = new TafelDAO();
        BestelItemDAO bestelItemDAL = new BestelItemDAO();
                
        public bool TafelStatus(int id)
        {
            Tafel tafel = tafelDAL.GetForId(id); // Nieuwe instantie van tafel vullen met juiste ID uit database
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
            List<BestelItem> alleBesteldeItems = bestelItemDAL.GetForTable(tafelId); // GetForTable haalt alle bestelde items van een geselecteerde tafel op
            List<Status> statuslist = new List<Status>();

            foreach (BestelItem item in alleBesteldeItems)
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
        }
    }
}
