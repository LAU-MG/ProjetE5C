using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using MesExceptions;
using Utilitaires;

namespace ProjetE5C
{
    public partial class Fprincipal : Form
    {
        private visiteur unVisiteur;

        private void Init_Etat()
        {
            deconnexionToolStripMenuItem.Enabled = false;
            médicamentsToolStripMenuItem.Enabled = false;
            rapportsToolStripMenuItem.Enabled = false;
            connexionToolStripMenuItem.Enabled = true;
        }

        public Fprincipal()
        {
            InitializeComponent();
            Init_Etat();
        }

        private void Fprincipal_Load(object sender, EventArgs e)
        {

        }

        private void miseAJourMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<visiteur> mesVisiteurs;
            try
            {

                mesVisiteurs = ServiceVisiteur.getInstance().GetListeVisiteur();
                Byte[] selByte;
                Byte[] mdpByte;
                String sel;
                String mdp;
                foreach (visiteur unV in mesVisiteurs)
                {
                    selByte = MonMotPassHash.GenerateSalt();
                    mdpByte = MonMotPassHash.PasswordHashe("secret", selByte);
                    sel = MonMotPassHash.BytesToString(selByte);
                    mdp = MonMotPassHash.BytesToString(mdpByte);
                    unV.sel_visiteur = sel;
                    unV.pwd_visiteur = mdp;
                }

                ServiceVisiteur.getInstance().MiseAjourDuModele();
                MessageBox.Show("Mise à jour", "Mise à jour effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] Credential = new String[] { " ", " " };
            String login;
            String mdp;

            Presentation.Fconnexion f = new Presentation.Fconnexion(Credential);

            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                //
                login = Credential[0];
                mdp = Credential[1];
                unVisiteur = ServiceConnexion.getInstance().RechercheUnVisiteur(login);
                // on controle le mot de passe
                try
                {
                    if (unVisiteur != null)
                    {
                        try
                        {
                            String sel = unVisiteur.sel_visiteur;
                            // on récupère le sel 
                            Byte[] salt = MonMotPassHash.transformeEnBytes(sel);
                            // on génère le mot de passe 
                            Byte[] tempo = MonMotPassHash.transformeEnBytes(unVisiteur.pwd_visiteur);
                            if (MonMotPassHash.VerifyPassword(salt, mdp, tempo) == true)

                            {
                                lb_etat.Text = "Etat connecté";
                                deconnexionToolStripMenuItem.Enabled = true;
                                médicamentsToolStripMenuItem.Enabled = true;
                                rapportsToolStripMenuItem.Enabled = true;
                                connexionToolStripMenuItem.Enabled = false;
                            }
                            else
                                MessageBox.Show("Erreur", "Erreur lors du contrôle  du mot de passe pour : " + Credential[0]);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Erreur", "Erreur lors du contrôle : " + err.Message);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur", "Erreur  login erroné : " + Credential[0]);

                    }
                }
                catch (MonException er)
                {
                    MessageBox.Show("Erreur", "Erreur lors de l'authentification : " + er.Message);

                }

            }
        }

            private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
            {
            unVisiteur = null;
            Init_Etat();
            }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                List<famille> FamMedicam = ServiceFamille.getInstance().FamMedicam();

                Presentation.FChoixFamille f = new Presentation.FChoixFamille(FamMedicam);
                f.ShowDialog();

            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, " La liste des médicaments par famille", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                constituer unComposant = new constituer();
                List<medicament> mesMeds = ServiceMédicamentscs.getInstance().ListedesMeds();
                List<composant> mesCompos = ServiceComposant.getInstance().ListedesCompos();
                Presentation.FAjoutComposant c = new Presentation.FAjoutComposant(mesCompos, mesMeds, unComposant);
                c.ShowDialog();

                ServiceConstituer.getInstance().ajoutComposant(unComposant);
                ServiceConstituer.getInstance().MiseAjourDuModele();
                ServiceVisiteur.getInstance().MiseAjourDuModele();
                MessageBox.Show("Votre Composant a bien était ajouter", "Ajouter un Composant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modifierCompoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<composant> mesC = ServiceMédicamentscs.getInstance().ListeDesCompo();
            Presentation.FAffichageCompo fAffichageCompo = new Presentation.FAffichageCompo(mesC);
            fAffichageCompo.ShowDialog(); ;



        }

        private void rapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajoutRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ajoutRapportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                rapport_visite unRapV = new rapport_visite();
                List<praticien> unPraticien = ServicePraticien.getInstance().listePraticien();
                List<visiteur> unVisiteur = ServiceVisiteur.getInstance().GetListeVisiteur();

                Presentation.RapportVisite.FajouterRapport r = new Presentation.RapportVisite.FajouterRapport(unPraticien, unVisiteur, unRapV);
                r.ShowDialog();

                ServiceRapport.getInstance().ajoutunRapport(unRapV);
                ServiceRapport.getInstance().MiseAjourDuModele();
                ServicePraticien.getInstance().MiseAjourDuModele();
                ServiceVisiteur.getInstance().MiseAjourDuModele();
                MessageBox.Show("Votre ", "Ajouter un Composant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void rapportVisiteNomPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<praticien> listePraticien = ServicePraticien.getInstance().listePraticien();

                Presentation.RapportVisite.FChoixNomP p = new Presentation.RapportVisite.FChoixNomP(listePraticien);
                p.ShowDialog();

            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, " La liste des médicaments par famille", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rapportVisiteDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<rapport_visite> DateRapport = ServiceRapport.getInstance().DateRapport();

                Presentation.RapportVisite.FChoixRVDate p = new Presentation.RapportVisite.FChoixRVDate(DateRapport);
                p.ShowDialog();

            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, " La liste des médicaments par famille", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void supprimerUnComposantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<medicament> mesM = ServiceMédicamentscs.getInstance().ListeDesMedicament();
            Presentation.SuppCompoChoixMedoc maSupp = new Presentation.SuppCompoChoixMedoc(mesM);
            maSupp.ShowDialog();

        }

        private void modificationEtSuppressionDunMédicamentOffertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<visiteur> mesVisisteurs = ServiceVisiteur.getInstance().GetListeVisiteur();
            Presentation.medicamentOffert.FChoixVisiteurModif choixVisiteur = new Presentation.medicamentOffert.FChoixVisiteurModif(mesVisisteurs);
            choixVisiteur.ShowDialog();
        }
    }
}
