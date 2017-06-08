using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systeem.DAO;
using Model;

namespace Systeem.Logica
{
    class Loginservice
    {
        public bool logincheck(int werknemer_id, string wachtwoord)
        {  

            MedewerkerDAO medewerkerDAL = new MedewerkerDAO();

            Medewerker medewerker = medewerkerDAL.GetForID(werknemer_id);

            bool result = medewerker.CheckWachtwoord(wachtwoord);



            return result;
        }
    }
   
}
