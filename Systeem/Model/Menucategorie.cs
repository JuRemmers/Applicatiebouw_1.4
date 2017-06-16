using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Menucategorie
    {
        private int id;
        public string Categorie { get; private set; }
        public int btw { get; private set; }
        public MenuKaart menu { get; private set; }

        public Menucategorie(int ID, string Cat, int btw, MenuKaart menu)
        {
            this.id = ID;
            this.Categorie = Cat;
            this.btw = btw;
            this.menu = menu;
        }

        public override string ToString()
        {
            return this.Categorie;
        }
    }
}
