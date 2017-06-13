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
        public double btwLaag;
        public double btwHoog;
        public double Prijs;
        public double fooi;
        public double totaalprijs { get; private set; }
        public Medewerker medewerker;
        public string opmerking;

        public Rekening(int Id, Bestelling bestelling)
        {
            this.Id = Id;
            this.bestelling = bestelling;
        }        
    }
}
