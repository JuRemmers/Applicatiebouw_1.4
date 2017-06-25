using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Logica
{
    public class Loginservice
    {
        // Jesse van Duijne
        public bool logincheck(int werknemer_id, string wachtwoord)
        {
            MedewerkerDAO medewerkerDAL = new MedewerkerDAO(); // Nieuwe instantie van medewerker

            Medewerker medewerker = medewerkerDAL.GetForID(werknemer_id); // Roept methode GetForID aan uit MedewerkerDAO in een nieuwe instantie van medewerker (Model-laag)
            
            if (medewerker != null) 
            {
                bool wachtwoordIsJuist = medewerker.CheckWachtwoord(wachtwoord); // Roept methode CheckWachtwoord aan uit Medewerker (model-laag)
                return wachtwoordIsJuist; // Returned de bool als invoer medewerker herkent wordt in database
            }

            else return false; // Als medewerker niet herkent wordt, wordt ook niks gereturned            
        }

    }
}
