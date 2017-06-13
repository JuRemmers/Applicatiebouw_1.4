using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systeem.DAO;
using Model;

namespace Systeem.Logica
{
    public class Loginservice
    {
        public bool logincheck(int werknemer_id, string wachtwoord)
        {
            MedewerkerDAO medewerkerDAL = new MedewerkerDAO(); // Nieuwe instantie van medewerker

            Medewerker medewerker = medewerkerDAL.GetForID(werknemer_id); // Roept methode GetForID aan uit MedewerkerDAO in een nieuwe instantie van medewerker (Model-laag)

            bool result;

            if (medewerker != null) 
            {
                result = medewerker.CheckWachtwoord(wachtwoord); // Roept methode CheckWachtwoord aan uit Medewerker (model-laag)
                return result; // Returned de bool als invoer medewerker niet herkent wordt in database
            }

            else return false; // Als medewerker niet herkent wordt, wordt ook niks gereturned            
        }
    }
}
