using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;
using Utilitaires;

namespace Domain
{
    public class ServiceConstituer
    {
        private static ServiceConstituer instance;
        private static LM_GsbE5CsharpEntities unService;

        public static ServiceConstituer getInstance()
        {
            if (ServiceConstituer.instance == null)
            {
                ServiceConstituer.instance = new ServiceConstituer();
                // on définit un contexte commun à toutes les requêtes
                unService = new LM_GsbE5CsharpEntities();
            }
            return ServiceConstituer.instance;
        }

        public void ajoutComposant(constituer unComposant)
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                unService.constituer.Add(unComposant);

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

        


        /// <summary>
        /// mise à jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MiseAjourDuModele()
        {
            sErreurs er = new sErreurs("Erreur  sur la mise à jour du modèle", "MiseAjourDuModele()");

            try
            {
                unService.SaveChanges();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
    }
}
