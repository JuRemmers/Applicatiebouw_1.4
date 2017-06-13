using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Kayleigh Vossen
namespace Model
{
    public class Rekening
    {
        private int bestelId;
        private double btwLaag;
        private double btwHoog;
        private double Prijs;
        private double fooi;
        private double totaalprijs;
        private Medewerker medewerker;
        private string opmerking;

        public Rekening(int bestelId, double btwLaag,double btwHoog,double Prijs,double fooi,double totaalprijs,Medewerker medewerker, string opmerking)
        {
            this.bestelId = bestelId;
            this.btwLaag = btwLaag;
            this.btwHoog = btwHoog;
            this.Prijs = Prijs;
            this.fooi = fooi;
            this.totaalprijs = totaalprijs;
            this.medewerker = medewerker;
            this.opmerking = opmerking;
        }
        
        public void UpdateTipAndTotaalprijs(int fooi)
        {
            this.fooi = fooi;
            totaalprijs = Prijs + this.fooi;
        }      
        
        public void UpdateOpmerking(string opmerking)
        {
            this.opmerking = opmerking;
        }  
    }
}
