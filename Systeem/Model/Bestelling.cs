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
        private Status status;
        private Tafel tafel;
        private Medewerker medewerker;

        public Bestelling(int ID, Status status, Tafel tafel, Medewerker medewerker)
        {
            this.ID = ID;
            this.status = status;
            this.tafel = tafel;
            this.medewerker = medewerker;
        }

        // Kayleigh
        public Bestelling(int ID)
        {
            this.ID = ID;
        }

        public override string ToString()
        {
            string String = "tafel: " + tafel.ID.ToString() + " " + "bestelling nmr: "+ ID.ToString() + " " + "status: " + status.ToString() ;

            return String;
        }
    }
}

