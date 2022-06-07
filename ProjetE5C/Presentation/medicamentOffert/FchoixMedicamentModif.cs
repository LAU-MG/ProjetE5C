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
    public partial class FchoixMedicamentModif : Form
    {
        private List<medicament> mesMedicaments;
        private int idVisiteur;
        public FchoixMedicamentModif(List<medicament> mesMed, int idV)
        {
            InitializeComponent();
            mesMedicaments = mesMed;
            idVisiteur = idV;
        }

        private void FchoixMedicamentModif_Load(object sender, EventArgs e)
        {
            cb_medicament.DisplayMember = "Text";
            cb_medicament.ValueMember = "Value";

            foreach (medicament unMedi in mesMedicaments)
            {
                cb_medicament.Items.Add(new { Text = unMedi.nom_commercial, Value = unMedi.id_medicament });
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            int idMedicament = (int)(cb_medicament.SelectedItem as dynamic).Value;

            List<rapport_visite> mesRapports = ServiceOffert.getInstance().getRapportOffrir(idVisiteur, idMedicament);
            medicamentOffert.FChoixRapportModif monChoixMedoc = new Presentation.medicamentOffert.FChoixRapportModif(idVisiteur, idMedicament, mesRapports);
            this.Hide();
            monChoixMedoc.ShowDialog();
            this.Close();
        }
    }
}
