using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuKaart
    {
        int id;
        string kaart;

        public MenuKaart(int id, string kaart)
        {
            this.id = id;
            this.kaart = kaart;
        }
    }
}
