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
        const double BTWL = 0.06;
        const double BTWH = 0.21;

        public void MaakTafelOverzicht(int id)
        {
            RekeningDAO rekening = new RekeningDAO();
            rekening.MakeTafelOverzicht(id);
        }

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
            BestelItemDAO item = new BestelItemDAO();
            List<BestelItem> items = item.GetMenuItemsByBestellingId(r.bestelling.ID);

            MedewerkerDAO med = new MedewerkerDAO();
            Medewerker m = med.GetMedewerkerNaam(r.medewerker.ID);
            

            double prijs = 0;

            // totaalprijs minus fooi
            foreach(BestelItem i in items)
            {
                double productprijs = i.aantal * i.item.prijs;
                prijs += productprijs;
            }
            double btwL = 0;
            double btwH = 0;
            double btw = 0;
            foreach(BestelItem i in items)
            {
                if(i.item.Categorie.btw == BTWL)
                {
                    btw = (i.item.prijs * i.aantal) * btwL;
                    btwL += btw;
                }
                else if(i.item.Categorie.btw == BTWH)
                {
                    btw = (i.item.prijs * i.aantal) * btwL;
                    btwH += btw;
                }
            }

            double fooi = 0;
            DateTime dt = DateTime.Now;

            //r.btwLaag = btwL;


            RekeningDAO rekening = new RekeningDAO();
            rekening.UpdateRekening(r);
        }
    }
}
