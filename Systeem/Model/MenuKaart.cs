using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuKaart
    {
        public int id { get; private set; }
        public string kaart { get; private set; }

        public MenuKaart(int id, string kaart)
        {
            this.id = id;
            this.kaart = kaart;
        }
    }
}
