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
        public double prijs { get; private set; }
        private Status status;
        private string opmerking;
        public DateTime tijd { get; private set; }

        public BestelItem(int id, Bestelling bestelling, MenuItem item,double prijs, int aantal, Status status, string opmerking, DateTime tijd)
        {
            this.ID = id;
            this.bestelling = bestelling;
            this.item = item;
            this.prijs = prijs;
            this.aantal = aantal;
            this.status = status;
            this.opmerking = opmerking;
            this.tijd = tijd;

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
            opmerking = "";
            status = Status.Uitgeserveerd;
        }
        public BestelItem(MenuItem item, int aantal, Status status)
        {
            this.item = item;
            this.aantal = aantal;
            this.status = status;
        }

        public bool Compare(BestelItem bestelitem)
        {
            if (this.item.ToString() == bestelitem.item.ToString())
            {
                this.aantal = this.aantal + bestelitem.aantal;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Vergelijk(string item)
        {
            if (this.item.ToString() == item)
            { return true; }

            else { return false; }
        }

        public void WijzigAantal(int aantal)
        {
            this.aantal = aantal;
        }
    }
}
