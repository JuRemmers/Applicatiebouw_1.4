using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        private int id;
        public string product { get; private set; }
        public double prijs { get; private set; }
        private int voorraad;
        public Menucategorie Categorie { get; private set; }
        private MenuKaart kaart;

        public MenuItem(int id, string product, double prijs, int vooraad, Menucategorie categorie, MenuKaart kaart)
        {
            this.id = id;
            this.product = product;
            this.prijs = prijs;
            this.voorraad = vooraad;
            this.Categorie = categorie;
            this.kaart = kaart;
        }

        public override string ToString()
        {
            string String = product + ", " + prijs;

            return String;
        }

        public MenuItem(string product, double prijs, Menucategorie Categorie)
        {
            this.product = product;
            this.Categorie = Categorie;
            this.prijs = prijs;
        }
    }
}
