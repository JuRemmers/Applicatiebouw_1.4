using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeem.Model
{
    class Medewerker
    {
        private int ID;
        private string voornaam;
        private string achternaam;
        private Functie functie;
        private string wachtwoord;
        
        public Medewerker(int id, string name, string surname, Functie function, string password)
        {
            this.ID = id;
            this.voornaam = name;
            this.achternaam = surname;
            this.functie = function;
            this.wachtwoord = password;
        }
    }

    
}
