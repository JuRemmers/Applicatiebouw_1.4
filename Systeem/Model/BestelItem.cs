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
        public Bestelling bestelling { get; private set; }
        public MenuItem item { get; private set; }
        public int aantal { get; private set; }
        public double prijs { get; private set; }
        public Status status { get; private set; }
        public string opmerking { get; set; }
        public DateTime tijd { get; private set; }

        public BestelItem(int id, Bestelling bestelling, MenuItem item, double prijs, int aantal, Status status, string opmerking, DateTime tijd)
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
            status = Status.Opgenomen;
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

        public void SetPrijs(double prijs)
        {
            this.prijs = prijs;
            this.tijd = DateTime.Now;
        }

        public void SetMenuItem(MenuItem item)
        {
            this.item = item;
        }

        public void SetBestelId(int id)
        {
            this.bestelling.SetID(id);
        }
    }
}
