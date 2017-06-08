using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeem.Model
{
    class MenuItem
    {
        private int id;
        private string product;
        private float prijs;
        private int voorraad;
        private Menucategorie categorie;
        private MenuKaart kaart;

        public MenuItem(int id, string product, float prijs, int vooraad, Menucategorie categorie, MenuKaart kaart)
        {
            this.id = id;
            this.product = product;
            this.prijs = prijs;
            this.voorraad = vooraad;
            this.categorie = categorie;
            this.kaart = kaart;
        }

        public override string ToString()
        {
            string String = product + ", " + prijs;

            return String;
        }

        //public override string ToString()
        //{
            
        //}
    }
}
