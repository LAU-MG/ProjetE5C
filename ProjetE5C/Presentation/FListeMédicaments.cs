using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetE5C.Presentation
{
    public partial class FListeMédicaments : Form
    {
        
        private DataTable mesMedicamFam = null;
        public FListeMédicaments(DataTable mesMF)
        {
           
            InitializeComponent();
            mesMedicamFam = mesMF;
        }

        private void FListeMédicaments_Load(object sender, EventArgs e)
        {
            dgvMedFam.DataSource = mesMedicamFam;
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMedFam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
