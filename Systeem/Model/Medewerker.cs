using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medewerker
    {
        public int ID { get; private set; }
        public string voornaam { get; private set; }
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

        public bool CheckWachtwoord(string wAchtwoord)
        {
            if (this.wachtwoord == wAchtwoord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
