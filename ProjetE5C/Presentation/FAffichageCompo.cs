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


        private List<composant> mesCompos;

        public FAffichageCompo( List<composant> mesC)
        {
            InitializeComponent();

            mesCompos = mesC;


        }


        private void FAffichageCompo_Load(object sender, EventArgs e)
        {

            cb_compo.DisplayMember = "Text";
            cb_compo.ValueMember = "Value";
            foreach (composant UnCompo in mesCompos)
            {
                cb_compo.Items.Add(new { Text = UnCompo.lib_composant, Value = UnCompo.id_composant });
            }


        }

        private void bt_ModifCompo_Click(object sender, EventArgs e)
        {
            int id_compo = (int)(cb_compo.SelectedIndex as dynamic).Value;

          
            FCompoModif idC = new FCompoModif(id_compo);
            idC.ShowDialog();



        }

        private void cb_compo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
