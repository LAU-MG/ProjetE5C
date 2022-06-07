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

namespace ProjetE5C.Presentation
{
    public partial class FCompoModif : Form
        
    {
        private int idCompo;
        ServiceMédicamentscs monService = new ServiceMédicamentscs();
        composant monCompo;

        public FCompoModif(int idC)
        {
            InitializeComponent();
            idCompo = idC;
            monCompo = monService.getmonCompo(idCompo);
            tb_CompoModif.Text = monCompo.lib_composant;
        }
   

        private void FCompoModif_Load(object sender, EventArgs e)
        {

        }

        private void bt_modifCompo_Click(object sender, EventArgs e)
        {
            monCompo.lib_composant = tb_CompoModif.Text;


            ServiceMédicamentscs.getInstance().MiseAjourDuModele();
            ServiceVisiteur.getInstance().MiseAjourDuModele();
            MessageBox.Show("Votre Composant à bien été modifié", "Modifier un Composant", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tb_CompoModif_TextChanged(object sender, EventArgs e)
        {

        } }
    }

