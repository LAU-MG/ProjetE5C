using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MesExceptions;
using Utilitaires;


namespace Domain
{
    public class ServiceOffert
    {

        private static ServiceOffert instance;
        private static LM_GsbE5CsharpEntities unService;

        public static ServiceOffert getInstance()
        {
            if (ServiceOffert.instance == null)
            {
                ServiceOffert.instance = new ServiceOffert();
                // on définit un contexte commun à toutes les requêtes
                unService = new LM_GsbE5CsharpEntities();
            }
            return ServiceOffert.instance;
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

        //Fonctions 

        public List<rapport_visite> getDateRapport()
        {

            sErreurs er = new sErreurs("Erreur sur lister les dates de rapport.", "getDateRapport()");


            try
            {
                var mesRapports = (from rv in unService.rapport_visite
                                   select rv).Distinct();

                return mesRapports.ToList<rapport_visite>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public List<praticien> getPraticiens()
        {

            sErreurs er = new sErreurs("Erreur sur lister les praticiens.", "getPraticiens()");


            try
            {
                var mesRapports = (from rv in unService.praticien
                                   select rv);

                return mesRapports.ToList<praticien>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }





        public DataTable getRapportbydate(DateTime maDate)
        {

            sErreurs er = new sErreurs("Erreur sur lister les rapport par date.", "getRapportbydate()");
            DataTable dt = new DataTable();


            try
            {
                dt.Columns.Add("date_rapport", typeof(DateTime));
                dt.Columns.Add("bilan", typeof(String));
                dt.Columns.Add("motif", typeof(String));


                var mesRapports = (from rv in unService.rapport_visite
                                   where rv.date_rapport == maDate
                                   select rv);

                foreach (var unRap in mesRapports)
                {

                    dt.Rows.Add(unRap.date_rapport, unRap.bilan, unRap.motif);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }


        }

        public DataTable getRapportbyprati(int idPrati)
        {

            sErreurs er = new sErreurs("Erreur sur lister les rapport par date.", "getRapportbydate()");
            DataTable dt = new DataTable();


            try
            {
                dt.Columns.Add("date_rapport", typeof(DateTime));
                dt.Columns.Add("bilan", typeof(String));
                dt.Columns.Add("motif", typeof(String));
                dt.Columns.Add("praticien", typeof(String));


                var mesRapports = (from rv in unService.rapport_visite
                                   join prati in unService.praticien on rv.id_praticien equals prati.id_praticien
                                   where rv.id_praticien == idPrati
                                   select rv);

                foreach (var unRap in mesRapports)
                {
                    dt.Rows.Add(unRap.date_rapport, unRap.bilan, unRap.motif, unRap.id_praticien);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }


        }


        public void ajouteRapport(rapport_visite unRapport)
        {
            sErreurs er = new sErreurs("Erreur  sur l'ajout d'un rapport.", "ajouteRapport");
            try
            {
                unService.rapport_visite.Add(unRapport);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

        public List<medicament> getMedicament()
        {

            sErreurs er = new sErreurs("Erreur sur lister les dates de rapport.", "getDateRapport()");


            try
            {
                var mesRapports = (from m in unService.medicament
                                   select m);

                return mesRapports.ToList<medicament>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public offrir getOffrir(int idV, int idM, int idR)
        {

            sErreurs er = new sErreurs("Erreur sur lister les dates de rapport.", "getDateRapport()");


            try
            {
                var monOffert = (from m in unService.offrir
                                 where m.id_visiteur == idV
                                 where m.id_medicament == idM
                                 where m.id_rapport == idR
                                 select m).First();

                return monOffert;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }


        public List<medicament> getListeOffrir(int idV)
        {

            sErreurs er = new sErreurs("Erreur sur lister les médicaments offert.", "getListeOffrir()");

            try
            {
                var mesRapports = (from m in unService.medicament
                                   join o in unService.offrir on m.id_medicament equals o.id_medicament
                                   where o.id_visiteur == idV
                                   select m);

                return mesRapports.ToList<medicament>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public List<rapport_visite> getRapportOffrir(int idV, int idM)
        {

            sErreurs er = new sErreurs("Erreur sur lister les médicaments offert.", "getListeOffrir()");

            try
            {
                var mesRapports = (from m in unService.rapport_visite
                                   join o in unService.offrir on m.id_rapport equals o.id_rapport
                                   where o.id_visiteur == idV
                                   where o.id_medicament == idM
                                   select m);

                return mesRapports.ToList<rapport_visite>();

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public void SuppOffert(offrir unOffert)
        {
            sErreurs er = new sErreurs("Erreur  sur la supression d'un consitue.", "suppConstitue");
            try
            {
                unService.offrir.Remove(unOffert);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

    }
}
