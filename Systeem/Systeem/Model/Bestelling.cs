using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeem.Model
{
    class Bestelling
    {
        // door Donna
        private int ID;
        private string product;
        private Status status;
        private Tafel tafel;
        private Medewerker medewerker;

        public Bestelling(int id, string product, Status status, Tafel tafel, Medewerker medewerker)
        {
            this.ID = id;
            this.product = product;
            this.status = status;
            this.tafel = tafel;
            this.medewerker = medewerker;
        }
    }
}

