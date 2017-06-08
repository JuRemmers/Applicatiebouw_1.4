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
        private int ID;
        private BestelItem product;
        private Status status;
        private Tafel tafel;
        private Medewerker medewerker;

        public Bestelling(int id, BestelItem product, Status status, Tafel tafel, Medewerker medewerker)
        {
            this.ID = id;
            this.product = product;
            this.status = status;
            this.tafel = tafel;
            this.medewerker = medewerker;
        }

        public override string ToString()
        {
            return product.ToString();
        }
    }
}

