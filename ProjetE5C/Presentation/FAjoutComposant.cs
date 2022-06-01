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
    public partial class FAjoutComposant : Form
    {
        constituer unConstitue; 
        List<composant> ListedesCompos;
        List<medicament> ListedesMeds;
        public FAjoutComposant(List<composant> mesCompos, List<medicament> mesMeds, constituer unConst)
        {
            InitializeComponent();
            ListedesCompos = mesCompos;
            ListedesMeds = mesMeds;
            unConstitue = unConst;

        }
        /// <summary>
        /// Contrôle des données numériques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void FAjoutComposant_Load(object sender, EventArgs e)
        {
            cb_ChoixMeds.DisplayMember = "Text";
            cb_ChoixMeds.ValueMember = "Value";
            foreach (medicament unMed in ListedesMeds)
            {
                cb_ChoixMeds.Items.Add(new { Text = unMed.nom_commercial, Value = unMed.id_medicament });
            }

            cb_Composant.DisplayMember = "Text";
            cb_Composant.ValueMember = "Value";
            foreach (composant unCompo in ListedesCompos)
            {
                cb_Composant.Items.Add(new { Text = unCompo.lib_composant, Value = unCompo.id_composant });
            }
            cb_ChoixMeds.SelectedIndex = 0;
            cb_Composant.SelectedIndex = 0;
        }

        private void tb_quantitee_TextChanged(object sender, EventArgs e)
        {



        }

        private void cb_Composant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_ChoixMeds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_ValiderAjoutCompo_Click(object sender, EventArgs e)
        {
            String temp = "";
            int v = (int)(cb_ChoixMeds.SelectedItem as dynamic).Value;
            int c = (int)(cb_Composant.SelectedItem as dynamic).Value;
            unConstitue.id_medicament = v;
            unConstitue.id_composant = c;
            // unRapport.id_etat =
            temp = tb_quantitee.Text;
            if (temp != "")
            {
                unConstitue.qte_composant = Decimal.Parse(temp);
                 
            }
            else
            {
                MessageBox.Show("Erreur de saisie", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_quantitee.Focus();
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}


