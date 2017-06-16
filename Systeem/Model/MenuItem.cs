using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int id { get; set; }
        public string product { get; private set; }
        public double prijs { get; private set; }
        public int voorraad { get; set; }
        public Menucategorie Categorie { get; set; }

        public MenuItem(int id, string product, double prijs, int vooraad, Menucategorie categorie)
        {
            this.id = id;
            this.product = product;
            this.prijs = prijs;
            this.voorraad = vooraad;
            this.Categorie = categorie;
        }

        public override string ToString()
        {
            return product;
        }

        // Kayleigh Vossen
        public MenuItem(string product, double prijs, Menucategorie Categorie)
        {
            this.product = product;
            this.Categorie = Categorie;
            this.prijs = prijs;
        }
        public MenuItem(string product)
        { 
            this.product = product;
        }
    }
}
