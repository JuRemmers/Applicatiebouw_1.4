using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rekening
    {
            public List<Bestelling> bestellingen;
            public int btwLaag;
            public int btwHoog;
            public int totaalPrijs;
            public int fooi;
            public DateTime datumTijd;
            public string medewerker;
            public string opmerking;
            public bool betaald;
        
        public Rekening(List<Bestelling> bestellingen, int btwLaag, int btwHoog, int totaalPrijs, int fooi, string medewerker, string opmerking, bool betaald)
        {
            this.bestellingen = bestellingen;
            this.btwLaag = btwLaag;
            this.btwHoog = btwHoog;
            this.totaalPrijs = totaalPrijs;
            this.fooi = fooi;
            this.medewerker = medewerker;
            this.opmerking = opmerking;
            this.betaald = betaald;
        }

        public void GetRekening()
        {

        }

        // foreach(Bestelling b in rekening)
        //    {
        //    foreach(BestelItem i in b){
        
        

    }
}
