using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kayleigh
namespace Model
{
    public class Rekening
    {
        public int Id { get; private set; }
        public Bestelling bestelling { get; private set; }
        public double btwLaag { get; private set; }
        public double btwHoog { get; private set; }
        public double totaalPrijs { get; private set; }
        public double fooi { get; private set; }
        public DateTime datumTijd { get; private set; }
        public Medewerker medewerker { get; private set; }
        public string opmerking { get; private set; }
        public bool betaald { get; private set; }

        public Rekening(int Id, Bestelling bestelling)
        {
            this.Id = Id;
            this.bestelling = bestelling;

        }

        public Rekening(int Id, Bestelling bestelling, double btwLaag, double btwHoog, double totaalPrijs, double fooi, DateTime datumTijd, Medewerker medewerker, bool betaald, string opmerking)
        {
            this.Id = Id;
            this.bestelling = bestelling;
            this.btwLaag = btwLaag;
            this.btwHoog = btwHoog;
            this.totaalPrijs = totaalPrijs;
            this.fooi = fooi;
            this.datumTijd = datumTijd;
            this.medewerker = medewerker;
            this.opmerking = opmerking;
            this.betaald = betaald;
        }
    }
}
