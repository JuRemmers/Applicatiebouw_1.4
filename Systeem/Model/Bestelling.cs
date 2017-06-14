using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class Bestelling
    {
        public int ID { get; private set; }
        private bool betaald;
        public Tafel tafel { get; private set; }
        public Medewerker medewerker { get; private set; }
        

        public Bestelling(int ID,  Tafel tafel, Medewerker medewerker)
        {
            this.ID = ID;
            this.betaald = false;
            this.tafel = tafel;
            this.medewerker = medewerker;
        }

        // Kayleigh Vossen
        public Bestelling(int ID)
        {
            this.ID = ID;
            this.betaald = false;
        }

        public override string ToString()
        {
            string String = "Tafel: " + tafel.ID.ToString() + " " + "Bestelling nmr: "+ ID.ToString() + " " + "Status: ";

            return String;
        }

        public void UpdateBetaald()
        {
            this.betaald = true;
        }


    }
}

