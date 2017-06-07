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
        private int btw;
        private MenuKaart kaart;

        public Menucategorie(int id, int btw, MenuKaart kaart)
        {
            this.id = id;
            this.btw = btw;
            this.kaart = kaart;

        }
    }
}
