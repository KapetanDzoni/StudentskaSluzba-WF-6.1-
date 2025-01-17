using StudentskaSluzbaWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzbaWF6._1
{
    public partial class UpisUnosIndeksa : Form
    {
        public UpisUnosIndeksa()
        {
            InitializeComponent();
        }
        public string indeks;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text.Length == 0)
            {
                MessageBox.Show("Molimo unesite svoj broj indeksa");
                return;
            }

            if (Validacije_podataka.proveraFormataIndeksa(textBox1.Text))
            {
                if (Fajl_opstih_metoda.daLiBrojIndeksaSmeDaSeKoristi(textBox1.Text))
                {
                    indeks = textBox1.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Ovaj broj indeksa je zauzet");
                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }
    }
}
