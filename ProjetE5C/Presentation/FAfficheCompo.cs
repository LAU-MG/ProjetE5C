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
    public partial class FAfficheCompo : Form
    {
        public DataTable mesCompo = null;
        public FAfficheCompo(DataTable mesC)
        {
            InitializeComponent();
            mesCompo = mesC;
        }

        private void dgMedoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quiiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAfficheCompo_Load(object sender, EventArgs e)
        {
            dgMedoc.DataSource = mesCompo;
        }
    }
}
