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
        public Status status { get; private set; }
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
        public BestelItem(MenuItem item, int aantal, Status status)
        {
            this.item = item;
            this.aantal = aantal;
            this.status = status;
        }

        public bool Compare(BestelItem item)
        {
            if (this.item == item.item)
            {
                this.aantal++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
