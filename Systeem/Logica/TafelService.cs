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
    }
}
