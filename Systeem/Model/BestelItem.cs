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
        private MenuItem item;         // heb je menu item nodig als je al bestelling hebt? list maken?
        private int aantal;
        private int voorraad;
        private Status status;
        private string opmerking;

        public BestelItem(int id, Bestelling bestelling, MenuItem item, int aantal, int voorraad, Status status, string opmerking)
        {
            this.ID = id;
            this.bestelling = bestelling;
            this.item = item;
            this.aantal = aantal;
            this.voorraad = voorraad;
            this.status = status;
            this.opmerking = opmerking;
        }

        public override string ToString()
        {
            return item.ToString() + ", " + aantal;
        }

        public BestelItem(MenuItem item, int aantal)
        {
            this.item = item;
            this.aantal = aantal;
        }
    }
}
