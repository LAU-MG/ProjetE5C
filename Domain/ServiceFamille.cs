using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;

namespace Domain
{
    public class ServiceFamille
    {
        private static ServiceFamille instance;
        private static LM_GsbE5CsharpEntities unService;
       

        public static ServiceFamille getInstance()
        {
            if (ServiceFamille.instance == null)
            {
                ServiceFamille.instance = new ServiceFamille();
                // on définit un contexte commun à toutes les requêtes
                unService = new LM_GsbE5CsharpEntities();
            }
            return ServiceFamille.instance;
        }

        public List<famille> FamMedicam()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                
               var lesFam = (from f in unService.famille
                             select f);


                return lesFam.ToList<famille>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }



    }
}
