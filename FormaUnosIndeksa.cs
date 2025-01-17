using StudentskaSluzbaWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzbaWF6._1
{
    public partial class FormaUnosIndeksa : Form
    {
        public FormaUnosIndeksa()
        {
            InitializeComponent();
        }
        public Student student;
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Molim vas unesite broj indeksa");
                return;
            }

            string indeks = textBox1.Text;

            if (!Validacije_podataka.proveraFormataIndeksa(indeks))
            {
                return;

            }


            foreach (Student s in Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata)
            {
                //  MessageBox.Show("Poredim :" + indeks + "  sa  " + s.BrojIndeksa +
                //     "Duzina stringa 1:" + indeks.Length + "  duzina stringa u bazi :" + s.BrojIndeksa.Length);

                // int rezultat = String.Compare(s.BrojIndeksa, indeks, StringComparison.OrdinalIgnoreCase);

                indeks = indeks.Trim().Normalize();
                string indeksUBazi = s.BrojIndeksa.Trim().Normalize();
                if (indeks.Equals(indeksUBazi))
                {
                    // MessageBox.Show("Student je pronadjen sa trim trim i normalize");
                    student = s;
                    DialogResult = DialogResult.OK;
                    this.Close();
                    this.Dispose();

                }


            }
            if (student == null)
            {
                MessageBox.Show("Taj broj indeksa se ne nalazi u listi upisanih studenata");
                return;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            // this.Dispose();
        }


    }


}

