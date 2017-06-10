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
        private List<BestelItem> producten ;
        private Status status;
        private Tafel tafel;
        private Medewerker medewerker;

        public Bestelling(int ID, List<BestelItem> producten, Status status, Tafel tafel, Medewerker medewerker)
        {
            this.ID = ID;
            this.producten = producten;
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
            return producten.ToString();
        }
    }
}

