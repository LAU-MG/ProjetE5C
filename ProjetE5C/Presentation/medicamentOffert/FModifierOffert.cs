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

namespace ProjetE5C.Presentation.medicamentOffert
{
    public partial class FModifierOffert : Form
    {
        private offrir monOffert;
        public FModifierOffert(offrir monO)
        {
            InitializeComponent();
            monOffert = monO;
            tb_quantite.Text = monOffert.qte_offerte.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FModifierOffert_Load(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            monOffert.qte_offerte = Int16.Parse(tb_quantite.Text);
            ServiceOffert.getInstance().MiseAjourDuModele();
            ServiceMédicamentscs.getInstance().MiseAjourDuModele();
            ServiceVisiteur.getInstance().MiseAjourDuModele();
            MessageBox.Show("Votre médicament offert à bien été modifié", "Modifier un médicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
