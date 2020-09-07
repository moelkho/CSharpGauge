using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestElkhomsiGauge2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {   try
            { userControl11.Valeur = float.Parse(textBox1.Text); }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning");
               
            }
            finally

            {
               /* on stock les valeurs mesurres dans une lisbox avec l'heure actuelle */

                listBox1.Items.Add("Valeur: " + float.Parse(textBox1.Text) + " Heure :"
                    + DateTime.Now);
            }
           
        }

        private void btnEffacer_Click(object sender, EventArgs e)

        {   /* on efface le text box et on remet la valeur a zero ainsi que le cercle de la jauge*/
            userControl11.Valeur = 0;
            textBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
