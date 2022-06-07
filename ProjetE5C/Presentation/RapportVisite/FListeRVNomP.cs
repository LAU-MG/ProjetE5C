using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetE5C.Presentation.RapportVisite
{
    public partial class FListeRVNomP : Form
    {
        private DataTable RapportVisiteNomP = null;
        public FListeRVNomP(DataTable RVNomP)
        {
            InitializeComponent();
            RapportVisiteNomP = RVNomP;
        }

        private void dvgNomP_RV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FListeRVNomP_Load(object sender, EventArgs e)
        {
            dvgNomP_RV.DataSource = RapportVisiteNomP;
        }
    }
}
