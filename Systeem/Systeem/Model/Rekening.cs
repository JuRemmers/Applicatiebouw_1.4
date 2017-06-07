using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeem.Model
{
    class Rekening
    {
            public List<Bestelling> rekening;
            public int btwLaag;
            public int btwHoog;
            public int totaalPrijs;
            public int fooi;
            public DateTime datumTijd;
            public string medewerker;
            public string opmerking;
            public bool betaald;
        
        public Rekening(List<Bestelling> bestellingen, int btwL, int btwH, int totaal, int tip, string naam, string comment, bool pay)
        {
            rekening = bestellingen;
            btwLaag = btwL;
            btwHoog = btwH;
            totaalPrijs = totaal;
            fooi = tip;
            datumTijd = DateTime.Now;
            medewerker = naam;
            opmerking = comment;
            betaald = pay;
        }
    }
}
