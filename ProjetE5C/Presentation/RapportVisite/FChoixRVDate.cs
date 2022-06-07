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
    
    public partial class FChoixRVDate : Form
    {
        public List<rapport_visite> DateRapport;
        public FChoixRVDate(List<rapport_visite> uneDate)
        {
            InitializeComponent();
            DateRapport = uneDate;
        }

        private void cb_RVDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FChoixRVDate_Load(object sender, EventArgs e)
        {
            cb_RVDate.DisplayMember = "Text";
            cb_RVDate.ValueMember = "Value";
            foreach (rapport_visite uneDate in DateRapport)
            {
                cb_RVDate.Items.Add(new { Text = uneDate.date_rapport, Value = uneDate.date_rapport });
            }
        }

        private void cb_ValiderRVDate_Click(object sender, EventArgs e)
        {
            DateTime id_rd = (DateTime)(cb_RVDate.SelectedItem as dynamic).Value;


            DataTable unRVDate = ServiceRapport.getInstance().RapportVisiteDate(id_rd);
            FListeRVDate RapportVisiteDate = new FListeRVDate(unRVDate);
            RapportVisiteDate.ShowDialog();
        }
    }
}
