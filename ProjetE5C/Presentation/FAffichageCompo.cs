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
    public partial class FAffichageCompo : Form
    {
 
        private int idMed;
        public FAffichageCompo(int idM)
        {
            InitializeComponent();
            idMed = idM;
            
        }

        private void tb_CompoModif_TextChanged(object sender, EventArgs e)
        {

        }

        private void FAffichageCompo_Load(object sender, EventArgs e)
        {

            


        }
    }
}
