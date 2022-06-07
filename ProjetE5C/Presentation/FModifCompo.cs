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

namespace ProjetE5C.Presentation
{
    public partial class FModifCompo : Form
    {
        List<medicament> ListedesMeds;

        public FModifCompo(List<medicament> mesMedicams)
        {
            InitializeComponent();
            ListedesMeds = mesMedicams;
  
            
        }
        

        private void FModifCompo_Load(object sender, EventArgs e)
        {

            cb_MedModif.DisplayMember = "Text";
            cb_MedModif.ValueMember = "Value";
            foreach (medicament unMed in ListedesMeds)
            {
                cb_MedModif.Items.Add(new { Text = unMed.nom_commercial, Value = unMed.id_medicament });
            }

            

        }

       

        private void btModifCompo_Click(object sender, EventArgs e)
        {

            int v = (int)(cb_MedModif.SelectedItem as dynamic).Value;
            DataTable mesCompo = ServiceMédicamentscs.getInstance().ListeDesCompobyIDMedoc(v);

            FAfficheCompo monAffichage = new FAfficheCompo(mesCompo);
            monAffichage.ShowDialog();

        }

        private void cb_MedModif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
