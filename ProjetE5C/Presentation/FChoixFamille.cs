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
    public partial class FChoixFamille : Form
    {
        
        public List<famille> mesFamilles;
        public FChoixFamille(List<famille> mesFam )
        {
            InitializeComponent();
            mesFamilles = mesFam;
            
        }

        private void cb_Famille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FChoixFamille_Load(object sender, EventArgs e)
        {
            cb_Famille.DisplayMember = "Text";
            cb_Famille.ValueMember = "Value";
            foreach( famille uneFam in mesFamilles)
            {
                cb_Famille.Items.Add(new { Text = uneFam.lib_famille, Value = uneFam.id_famille });
            }
        }

        private void bt_Valider_Click(object sender, EventArgs e)
        {
            int idFam = (int)(cb_Famille.SelectedItem as dynamic).Value;


            DataTable mesMF = ServiceMédicamentscs.getInstance().mesMedicamFam(idFam);
            FListeMédicaments mesMedicamFam = new FListeMédicaments(mesMF);
            mesMedicamFam.ShowDialog();
        }
    }
}
