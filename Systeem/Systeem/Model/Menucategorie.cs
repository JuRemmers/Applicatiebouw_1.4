using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeem.Model
{
    class Menucategorie
    {
        private int id;
        private string categorie;
        private int btw;
        private int menukaartID;

        public Menucategorie(int ID, string Cat, int btw, int menu)
        {
            this.id = ID;
            this.categorie = Cat;
            this.btw = btw;
            this.menukaartID = menu;
        }
    }
}
