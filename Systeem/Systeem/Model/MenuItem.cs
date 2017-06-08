using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeem.Model
{
    class MenuItem
    {
        private float prijs;
        private int id;
        private int voorraad;
        private Menucategorie categorie;
        private MenuKaart kaart;

        public MenuItem(float prijs, int id, int vooraad, Menucategorie categorie, MenuKaart kaart)
        {
            this.prijs = prijs;
            this.id = id;
            this.voorraad = vooraad;
            this.categorie = categorie;
            this.kaart = kaart;

        }

        //public override string ToString()
        //{
            
        //}
    }
}
