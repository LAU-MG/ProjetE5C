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


namespace ProjetE5C.Presentation
{
    public partial class SuppCompoChoixMedoc : Form
    {
        private List<medicament> mesMedocs;
        public SuppCompoChoixMedoc(List<medicament> mesM)
        {
            InitializeComponent();
            mesMedocs = mesM;
        }

        private void SuppCompoChoixMedoc_Load(object sender, EventArgs e)
        {
            cb_medoc.DisplayMember = "Text";
            cb_medoc.ValueMember = "Value";

            foreach (medicament unMedoc in mesMedocs)
            {
                cb_medoc.Items.Add(
                    new { Text = unMedoc.nom_commercial, Value = unMedoc.id_medicament }
                    );
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            int idMed = (int)(cb_medoc.SelectedItem as dynamic).Value;
            ServiceMédicamentscs monService = new ServiceMédicamentscs();
            List<composant> mesc = monService.ListeDesCompobyID(idMed);
            FSuppCompo Fcompo = new FSuppCompo(idMed, mesc);
            Fcompo.ShowDialog();

        }
    }
}
