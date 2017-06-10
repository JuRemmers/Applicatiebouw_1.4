using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Systeem.DAO;

namespace Systeem.Logica
{
    class RekeningService
    {
        public Rekening GetTafelOverzichtByTafelId(int id)
        {
            RekeningDAO rekening = new RekeningDAO();
            Rekening r = rekening.GetTafelOverzichtByTafelId(id);
            return r;
        }

        public Rekening GetRekeningByBestelId(Rekening r)
        {
            RekeningDAO rekening = new RekeningDAO();
            Rekening rek = rekening.GetRekeningByBestelId(r.Id);
            return rek;
        }

        public Rekening GetRekeningByRekeningId(Rekening r)
        {
            RekeningDAO rekening = new RekeningDAO();
            Rekening rek = rekening.GetRekeningByRekeningId(r.Id);
            return rek;
        }

        public void MaakRekening(Rekening r)
        {
            RekeningDAO rekening = new RekeningDAO();
            rekening.MakeRekening(r);
        }
    }
}
