using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;


namespace Domain
{
    public class ServicePraticien
    {
        private static ServicePraticien instance;
        private static LM_GsbE5CsharpEntities unService;

        public static ServicePraticien getInstance()
        {
            if (ServicePraticien.instance == null)
            {
                ServicePraticien.instance = new ServicePraticien();
                // on définit un contexte commun à toutes les requêtes
                unService = new LM_GsbE5CsharpEntities();
            }
            return ServicePraticien.instance;
        }

        public List<praticien> listePraticien()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {

                var lesPraticiens = (from p in unService.praticien
                              select p);


                return lesPraticiens.ToList<praticien>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }


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
