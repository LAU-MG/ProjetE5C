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

namespace ProjetE5C.Presentation.medicamentOffert
{
    public partial class FChoixVisiteurModif : Form
    {
        private List<visiteur> mesVisiteurs;
        public FChoixVisiteurModif(List<visiteur> mesV)
        {
            InitializeComponent();
            mesVisiteurs = mesV;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_visiteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FChoixVisiteurModif_Load(object sender, EventArgs e)
        {
            cb_visiteur.DisplayMember = "Text";
            cb_visiteur.ValueMember = "Value";

            foreach (visiteur unVisiteur in mesVisiteurs)
            {
                cb_visiteur.Items.Add(new { Text = unVisiteur.prenom_visiteur + " " + unVisiteur.nom_visiteur, Value = unVisiteur.id_visiteur });
            }

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {

            int idVisiteur = (int)(cb_visiteur.SelectedItem as dynamic).Value;
            List<medicament> mesMedocs = ServiceOffert.getInstance().getListeOffrir(idVisiteur);
            FchoixMedicamentModif monChoixMedoc = new FchoixMedicamentModif(mesMedocs, idVisiteur);
            this.Hide();
            monChoixMedoc.ShowDialog();
            this.Close();

        }
    }
}
