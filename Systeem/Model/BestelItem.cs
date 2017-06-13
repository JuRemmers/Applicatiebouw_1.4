using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestelItem
    {
        private int ID;
        private Bestelling bestelling;
        public MenuItem item { get; private set; }
        public int aantal { get; private set; }
        private Status status;
        private string opmerking;

        public BestelItem(int id, Bestelling bestelling, MenuItem item, int aantal, Status status, string opmerking)
        {
            this.ID = id;
            this.bestelling = bestelling;
            this.item = item;
            this.aantal = aantal;
            this.status = status;
            this.opmerking = opmerking;
        }

        public override string ToString()
        {
            return item.ToString() + ", " + aantal;
        }

        // Kayleigh Vossen
        public BestelItem(MenuItem item, int aantal)
        {
            this.item = item;
            this.aantal = aantal;
        }
    }
}
