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
    public partial class FChoixRapportModif : Form
    {
        private List<rapport_visite> mesRapports;
        private int idVisiteur;
        private int idMedicament;
        public FChoixRapportModif(int idV, int idM, List<rapport_visite> mesR)
        {
            InitializeComponent();
            mesRapports = mesR;
            idVisiteur = idV;
            idMedicament = idM;
        }

        private void cb_rapport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FChoixRapportModif_Load(object sender, EventArgs e)
        {
            cb_rapport.DisplayMember = "Text";
            cb_rapport.ValueMember = "Value";

            foreach (rapport_visite unRap in mesRapports)
            {
                cb_rapport.Items.Add(new { Text = unRap.motif, Value = unRap.id_rapport });
            }
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            int idRapport = (int)(cb_rapport.SelectedItem as dynamic).Value;
            offrir monOffert = ServiceOffert.getInstance().getOffrir(idVisiteur, idMedicament, idRapport);

            ServiceOffert.getInstance().SuppOffert(monOffert);

            ServiceOffert.getInstance().MiseAjourDuModele();
            ServiceMédicamentscs.getInstance().MiseAjourDuModele();
            ServiceVisiteur.getInstance().MiseAjourDuModele();
            MessageBox.Show("Votre médicament offert à bien été supprimé", "Modifier un supprimé  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            int idRapport = (int)(cb_rapport.SelectedItem as dynamic).Value;

            offrir monOffert = ServiceOffert.getInstance().getOffrir(idVisiteur, idMedicament, idRapport);
            Presentation.medicamentOffert.FModifierOffert monChoixMedoc = new Presentation.medicamentOffert.FModifierOffert(monOffert);
            this.Hide();
            monChoixMedoc.ShowDialog();
            this.Close();
        }
    }
}
