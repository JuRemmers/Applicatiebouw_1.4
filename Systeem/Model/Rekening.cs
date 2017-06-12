﻿using System;
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
        public double btwLaag;
        public double btwHoog;
        public double Prijs;
        public double fooi;
        public double totaalprijs;
        public DateTime datumTijd;
        public Medewerker medewerker;
        public string opmerking;
        public bool betaald;

        public Rekening(int Id, Bestelling bestelling)
        {
            this.Id = Id;
            this.bestelling = bestelling;

        }

        public Rekening(int Id, Bestelling bestelling, double btwLaag, double btwHoog, double Prijs, double fooi, DateTime datumTijd, Medewerker medewerker, bool betaald, string opmerking)
        {
            this.Id = Id;
            this.bestelling = bestelling;
            this.btwLaag = btwLaag;
            this.btwHoog = btwHoog;
            this.Prijs = Prijs;
            this.fooi = fooi;
            this.totaalprijs = Prijs + fooi;
            this.datumTijd = datumTijd;
            this.medewerker = medewerker;
            this.opmerking = opmerking;
            this.betaald = betaald;
        }
        
    }
}
