using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;
using Utilitaires;
using System.Data;

namespace Domain
{
    public class ServiceRapport
    {
        private static ServiceRapport instance;
        private static LM_GsbE5CsharpEntities unService;


        public static ServiceRapport getInstance()
        {
            if (ServiceRapport.instance == null)
            {
                ServiceRapport.instance = new ServiceRapport();
                // on définit un contexte commun à toutes les requêtes
                unService = new LM_GsbE5CsharpEntities();
            }
            return ServiceRapport.instance;
        }

        public void ajoutunRapport(rapport_visite unRapV)
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {

                unService.rapport_visite.Add(unRapV);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public DataTable RapportVisiteNomP(int id_p)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture du client.",
         "Clientel.LectureNoClient()");
            try
            {
                dt.Columns.Add("id_rapport", typeof(int));
                dt.Columns.Add("id_praticien", typeof(int));
                dt.Columns.Add("date_rapport", typeof(DateTime));
                dt.Columns.Add("bilan", typeof(String));
                dt.Columns.Add("motif", typeof(String));

                var mesRV = (from r in unService.rapport_visite
                             where r.id_praticien == id_p
                             select r);
                foreach (var res in mesRV)
                {

                    dt.Rows.Add(res.id_rapport, res.id_praticien, res.date_rapport, res.motif
                  );
                }
                return dt;
            }

            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

        public DataTable RapportVisiteDate( DateTime id_rd)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture du client.",
         "Clientel.LectureNoClient()");
            try
            {
                dt.Columns.Add("id_rapport", typeof(int));
                dt.Columns.Add("id_praticien", typeof(int));
                dt.Columns.Add("date_rapport", typeof(DateTime));
                dt.Columns.Add("bilan", typeof(String));
                dt.Columns.Add("motif", typeof(String));

                var mesRV = (from r in unService.rapport_visite
                             where r.date_rapport == id_rd
                             select r);
                foreach (var res in mesRV)
                {

                    dt.Rows.Add(res.id_rapport, res.id_praticien, res.date_rapport, res.motif
                  );
                }
                return dt;
            }

            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

        public List<rapport_visite> DateRapport()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {

                var lesRapportVisite = (from p in unService.rapport_visite
                                     select p);


                return lesRapportVisite.ToList<rapport_visite>();
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