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
    public partial class Fconnexion : Form
    {
        private String[] credential;
        public Fconnexion()
        {
            InitializeComponent();
        }

        public Fconnexion(String[] tab)
        {
            InitializeComponent();

            credential = tab;
        }

        private void Fconnexion_Load(object sender, EventArgs e)
        {

        }

        private void btValider_Click(object sender, EventArgs e)
        {
            credential[0] = tbLogin.Text;

            if (credential[0] == "")
                tbLogin.Focus();
            else
            {
                credential[1] = tbMotPasse.Text;
                if (credential[1] == "")
                {
                    tbMotPasse.Focus();
                }
            }
        }
    }
}
