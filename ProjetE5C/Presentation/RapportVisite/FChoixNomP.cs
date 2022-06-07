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

namespace ProjetE5C.Presentation.RapportVisite
{
    public partial class FChoixNomP : Form
    {
        public List<praticien> lesPraticiens;
        public FChoixNomP(List<praticien> lesP)
        {
            InitializeComponent();
            lesPraticiens = lesP;
        }

        private void FChoixNomP_Load(object sender, EventArgs e)
        {
            cb_rvNomP.DisplayMember = "Text";
            cb_rvNomP.ValueMember = "Value";
            foreach (praticien lesP in lesPraticiens)
            {
                cb_rvNomP.Items.Add(new { Text = lesP.nom_praticien, Value = lesP.id_praticien });
            }
        }

        private void cb_rvNomP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            int id_p = (int)(cb_rvNomP.SelectedItem as dynamic).Value;


            DataTable RVNomP = ServiceRapport.getInstance().RapportVisiteNomP(id_p);
            FListeRVNomP RapportVisiteNomP = new FListeRVNomP(RVNomP);
            RapportVisiteNomP.ShowDialog();
        }
    }
}
