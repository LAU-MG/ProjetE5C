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
    public partial class FSuppCompo : Form
    {
        private int idMed;
        private List<composant> mesCompos;

        public FSuppCompo(int id, List<composant> mesC)
        {
            InitializeComponent();
            idMed = id;
            mesCompos = mesC;
        }

        private void FSuppCompo_Load(object sender, EventArgs e)
        {
            cb_compo.DisplayMember = "Text";
            cb_compo.ValueMember = "Value";

            foreach (composant unCompo in mesCompos)
            {
                cb_compo.Items.Add(
                    new { Text = unCompo.lib_composant, Value = unCompo.id_composant }
                    );
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            int c = (int)(cb_compo.SelectedItem as dynamic).Value;


            ServiceMédicamentscs monService = new ServiceMédicamentscs();
            constituer myCompo = monService.getunCompobyID(idMed, c);

            ServiceMédicamentscs.getInstance().SuppCompo(myCompo);
            ServiceMédicamentscs.getInstance().MiseAjourDuModele();
            ServiceVisiteur.getInstance().MiseAjourDuModele();
            MessageBox.Show("Votre Composant à bien été supprimé", "Ajouter un Composant", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
