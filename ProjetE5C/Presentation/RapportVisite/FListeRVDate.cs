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
    public partial class FListeRVDate : Form
    {
        private DataTable RapportVisiteDate = null;
        public FListeRVDate(DataTable unRVDate)
        {
            InitializeComponent();
            RapportVisiteDate = unRVDate;
        }

        private void FListeRVDate_Load(object sender, EventArgs e)
        {
            dgv_RVDate.DataSource = RapportVisiteDate;
        }

        private void dgv_RVDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
