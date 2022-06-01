using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;
using Utilitaires;

namespace Domain
{
    public class ServiceVisiteur
    {
        private static ServiceVisiteur instance;
        private static LM_GsbE5CsharpEntities unService;
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static ServiceVisiteur getInstance()
        {
            if (ServiceVisiteur.instance == null)
            {
                ServiceVisiteur.instance = new ServiceVisiteur();
                // on définit un contexte commun à toutes les requêtes
                unService = new LM_GsbE5CsharpEntities();
            }
            return ServiceVisiteur.instance;
        }
        // Le constructeur devient privé
        private ServiceVisiteur()
        { }

        /// <summary>
        /// contrôle du login d'un visiteur
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>


        public visiteur RechercheUnVisiteur(Int32 numV)
        {

            sErreurs er = new sErreurs("Erreur sur recherche d'un visiteur.", "RechercheUnVisiteur()");
            visiteur unVisiteur;
            try
            {

                unVisiteur = (from v in unService.visiteur
                              where v.id_visiteur == numV
                              select v).FirstOrDefault();
                return unVisiteur;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

        public List<visiteur> GetListeVisiteur()
        {

            sErreurs er = new sErreurs("Erreur liste des visiteurs.", "GetListeVisiteur()");

            try
            {

                var mesVisiteurs = (from v in unService.visiteur
                                    select v);


                return mesVisiteurs.ToList<visiteur>();
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
