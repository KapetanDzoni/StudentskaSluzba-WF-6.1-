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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentskaSluzbaWF6._1
{
    public partial class PolaganjeIspita : Form
    {
        Student student;
        public PolaganjeIspita()
        {
            InitializeComponent();
        }

        public PolaganjeIspita(Student S)
        {
            InitializeComponent();
            this.student = S;
            prikaziIspiteKojiMoguDaSePolazu();
            label2.Text = student.ImeIPrezime;
            label3.Text = student.BrojIndeksa;
        }

        public void prikaziIspiteKojiMoguDaSePolazu()
        {
            string zaPrikaz;
            int brojac = 1;

            if (student.listaOdabranihIspita.Count==0)
            {
                listBox1.Items.Add("Student nije odabrao ni jedan ispit za slušanje");
                return;
            }

            foreach (Ispit i in student.listaOdabranihIspita)
            {
                zaPrikaz = brojac.ToString() + ". " + i.Naziv;
                listBox1.Items.Add(zaPrikaz);
                brojac++;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(listBox1.Text))
            {
                MessageBox.Show("Molim vas odaberite predmet za polaganje");
                return;
            }


            if (listBox1.SelectedItem.ToString()!=null)
            {
                string nazivOdabranogIspita = listBox1.SelectedItem.ToString().Substring(3);

                Ispit i = Fajl_opstih_metoda.pronadjiIspitPoImenu(nazivOdabranogIspita);


                if (i != null)
                {

                    UnosOcene UO = new UnosOcene(student, i);


                    UO.ShowDialog();

                    if (UO.ocena > 5)
                    {
                        student.listaOdabranihIspita.Remove(i);


                        UpisIIspisIzBaze.sacuvajUBazuStudenata(Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata, Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeStudenata);
                    }


                }
            }
           
            


            DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }
    }
}
