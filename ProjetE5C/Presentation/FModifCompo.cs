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
    public partial class FModifCompo : Form

    {


        
        List<medicament> ListedesMeds;
       
        public FModifCompo(List<medicament> mesMedicams)
        {
            InitializeComponent();
            ListedesMeds = mesMedicams;
            
        }
        private void nb_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                var controller = (TextBox)sender;
                String text = controller.Text;

                if (NombreOccurence(text, '.') == 1)
                {
                    if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
                else
                {
                    if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)46))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
        }

        int NombreOccurence(String chn, char c)
        {
            int cnt = 0;
            foreach (char car in chn)
            {
                if (c == car) cnt++;
            }
            return cnt;
        }

        private void tb_qtiteCompo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FModifCompo_Load(object sender, EventArgs e)
        {
            foreach (medicament unMed in ListedesMeds)
            {
                cb_MedModif.Items.Add(new { Text = unMed.nom_commercial, Value = unMed.id_medicament });
            }
            cb_MedModif.DisplayMember = "Text";
            cb_MedModif.ValueMember = "Value";
         

        }

        private void cb_MedModif_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        private void btModifCompo_Click(object sender, EventArgs e)
        {
            int v = (int)(cb_MedModif.SelectedIndex as dynamic).Value;
           


           FAffichageCompo idM = new FAffichageCompo(v);
            idM.ShowDialog();

        }
    }
}
