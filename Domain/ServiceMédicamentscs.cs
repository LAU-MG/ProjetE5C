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

        public List<medicament> ListeDesMedicament()
        {

            sErreurs er = new sErreurs("Erreur sur lecture des medicament.", "Lecturemedicament");

            try
            {

                var lesMedicaments = (from m in unService.medicament
                                      select m);

                return lesMedicaments.ToList<medicament>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public DataTable ListeDesCompobyIDMedoc(int idM)
        {

            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture du composant.", "Clientel.LectureNoClient()");

            try
            {
                dt.Columns.Add("id_composant", typeof(int));
                dt.Columns.Add("lib_composant", typeof(String));


                var lesCompo = (from c in unService.composant
                                join consti in unService.constituer on c.id_composant equals consti.id_composant
                                join m in unService.medicament on consti.id_medicament equals m.id_medicament
                                where m.id_medicament == idM
                                select c);



                foreach (var unCompo in lesCompo)
                {

                    dt.Rows.Add(unCompo.id_composant, unCompo.lib_composant);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }



        public List<composant> ListeDesCompobyID(int idM)
        {

            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "Lecturecomposants");

            try
            {

                var lesCompo = (from c in unService.composant
                                join consti in unService.constituer on c.id_composant equals consti.id_composant
                                join m in unService.medicament on consti.id_medicament equals m.id_medicament
                                where m.id_medicament == idM
                                select c);



                return lesCompo.ToList<composant>();
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

        public composant getmonCompo(int idC)
        {

            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "Lecturecomposants");

            try
            {

                var monCompo = (from c in unService.composant
                                where c.id_composant == idC
                                select c).First();



                return monCompo;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public List<composant> ListeDesCompo()
        {

            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "Lecturecomposants");

            try
            {

                var lesCompo = (from c in unService.composant
                                select c);

                return lesCompo.ToList<composant>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public void SuppCompo(constituer unCompo)
        {
            sErreurs er = new sErreurs("Erreur  sur la supression d'un consitue.", "suppConstitue");
            try
            {
                unService.constituer.Remove(unCompo);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

        public constituer getunCompobyID(int idM, int idC)
        {

            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "Lecturecomposants");

            try
            {

                var monCompo = (from c in unService.constituer
                                where c.id_medicament == idM
                                where c.id_composant == idC
                                select c).First();



                return monCompo;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }



    }

}
