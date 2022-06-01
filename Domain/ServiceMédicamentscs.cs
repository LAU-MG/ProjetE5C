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
    public class ServiceMédicamentscs
    {
        private static ServiceMédicamentscs instance;
        private static LM_GsbE5CsharpEntities unService;

        public static ServiceMédicamentscs getInstance()
        {
            if (ServiceMédicamentscs.instance == null)
            {
                ServiceMédicamentscs.instance = new ServiceMédicamentscs();
                // on définit un contexte commun à toutes les requêtes
                unService = new LM_GsbE5CsharpEntities();
            }
            return ServiceMédicamentscs.instance;
        }

public DataTable mesMedicamFam(int id_fam) {
        DataTable dt = new DataTable();
        sErreurs er = new sErreurs("Erreur sur lecture du client.",
     "Clientel.LectureNoClient()");
            try
            {
                dt.Columns.Add("id_medicament", typeof(int));
                dt.Columns.Add("depot_legal", typeof(String));
                dt.Columns.Add("nom_commercial", typeof(String));
                dt.Columns.Add("effets", typeof(String));

                var mesMF = (from m in unService.medicament
                             where m.id_famille == id_fam
                             select m);
                foreach (var res in mesMF)
                {

                    dt.Rows.Add(res.id_medicament, res.depot_legal, res.nom_commercial, res.effets 
                  );
                }
                return dt;
            }

            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

    }
        public List<medicament> ListedesMeds()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {

                var lesM = (from m in unService.medicament
                              select m);


                return lesM.ToList<medicament>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }



    }
    
}
