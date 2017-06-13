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
        public Status status { get; private set; }
        public Tafel tafel { get; private set; }
        public Medewerker medewerker { get; private set; }

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
            string String = "Tafel: " + tafel.ID.ToString() + " " + "Bestelling nmr: "+ ID.ToString() + " " + "Status: " + status.ToString() ;

            return String;
        }
    }
}

