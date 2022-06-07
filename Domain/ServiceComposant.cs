using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;

namespace Domain
{
    public class ServiceComposant
    {
        private static ServiceComposant instance;
        private static LM_GsbE5CsharpEntities unService;

        public static ServiceComposant getInstance()
        {
            if (ServiceComposant.instance == null)
            {
                ServiceComposant.instance = new ServiceComposant();
                // on définit un contexte commun à toutes les requêtes
                unService = new LM_GsbE5CsharpEntities();
            }
            return ServiceComposant.instance;
        }
        public List<composant> ListedesCompos()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {

                var lesCompos = (from c in unService.composant
                              select c);


                return lesCompos.ToList<composant>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
         public void ajoutComposant (constituer unComposant)
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

        public List<composant> UnComposant(int id_compo)
        {
            sErreurs er = new sErreurs("Erreur  sur la mise à jour du modèle", "MiseAjourDuModele()");


            try
            {

                var C = (from m in unService.composant
                        where m.id_composant == id_compo
                         select m);
               
                return C.ToList<composant>();
            }

            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public composant UnCompo(int id_compo)
        {
            sErreurs er = new sErreurs("Erreur  sur la mise à jour du modèle", "MiseAjourDuModele()");


            try
            {

                var C = (from m in unService.composant
                         where m.id_composant == id_compo
                         select m).First();

                return C;
            }

            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
