using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        public int ID { get; set; }
        public bool Bezet { get; set; }

        public Tafel(int ID, bool Bezet)
        {
            this.ID = ID;
            this.Bezet = Bezet;
        }

        public override string ToString()
        {
            string tafel = ID.ToString() + Bezet.ToString();
            return tafel;
        }
    }
}
