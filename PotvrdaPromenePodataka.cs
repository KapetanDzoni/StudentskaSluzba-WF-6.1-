using StudentskaSluzbaWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzbaWF5._1
{
    public partial class PotvrdaPromenePodataka : Form
    {
        private Student S3;
        private Student S4;
        public PotvrdaPromenePodataka()
        {
            InitializeComponent();
        }
        public PotvrdaPromenePodataka(Student Stari, Student Novi)
        {

            InitializeComponent();

            prikaziPromene(Stari, Novi);
            S3 = Stari;
            S4 = Novi;
        }


        private void prikaziPromene(Student S, Student S2)
        {

            if (!S.ImeIPrezime.Equals(S2.ImeIPrezime))
            {
                listBox1.Items.Add("Ime i prezime:" + S.ImeIPrezime);
                listBox2.Items.Add("Ime i prezime:" + S2.ImeIPrezime);
            }
            if (!S.ImeRoditelja.Equals(S2.ImeRoditelja))
            {
                listBox1.Items.Add("Ime roditelja:" + S.ImeRoditelja);
                listBox2.Items.Add("Ime roditelja:" + S2.ImeRoditelja);
            }
            if (!S.DatumRodjenja.Equals(S2.DatumRodjenja))
            {
                listBox1.Items.Add("Datum rodjenja:" + S.DatumRodjenja);
                listBox2.Items.Add("Datum rodjenja:" + S2.DatumRodjenja);
            }
            if (!S.DrzavaRodjenja.Equals(S2.DrzavaRodjenja))
            {
                listBox1.Items.Add("Država:" + S.DrzavaRodjenja);
                listBox2.Items.Add("Država:" + S2.DrzavaRodjenja);
            }
            if (!S.OpstinaRodjenja.Equals(S2.OpstinaRodjenja))
            {
                listBox1.Items.Add("Opština rodjenja:" + S.OpstinaRodjenja);
                listBox2.Items.Add("Opština rodjenja:" + S2.OpstinaRodjenja);
            }
            if (!S.Drzavljanstvo.Equals(S2.Drzavljanstvo))
            {
                listBox1.Items.Add("Državljanstvo:" + S.Drzavljanstvo);
                listBox2.Items.Add("Državljanstvo:" + S2.Drzavljanstvo);
            }
            if (!S.Jmbg.Equals(S2.Jmbg))
            {
                listBox1.Items.Add("JMBG:" + S.Jmbg);
                listBox2.Items.Add("JMBG:" + S2.Jmbg);
            }
            if (!S.VrstaStudija.Equals(S2.VrstaStudija))
            {
                listBox1.Items.Add("Vrsta studija:" + S.VrstaStudija);
                listBox2.Items.Add("Vrsta studija:" + S2.VrstaStudija);
            }
            if (!S.Smer.Equals(S2.Smer))
            {
                listBox1.Items.Add("Smer:" + S.Smer);
                listBox2.Items.Add("Smer:" + S2.Smer);
            }
            if (!S.GodinaStudija.Equals(S2.GodinaStudija))
            {
                listBox1.Items.Add("Godina studija:" + S.GodinaStudija);
                listBox2.Items.Add("Godina studija:" + S2.GodinaStudija);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

            S3.ImeIPrezime = S4.ImeIPrezime;
            S3.ImeRoditelja = S4.ImeRoditelja;
            S3.DatumRodjenja = S4.DatumRodjenja;
            S3.DrzavaRodjenja = S4.DrzavaRodjenja;
            S3.Drzavljanstvo = S4.Drzavljanstvo;
            S3.OpstinaRodjenja = S4.OpstinaRodjenja;
            S3.Jmbg = S4.Jmbg;
            S3.VrstaStudija = S4.VrstaStudija;
            S3.Smer = S4.Smer;
            S3.GodinaStudija = S4.GodinaStudija;

            MessageBox.Show("Svi podaci su uspešno promenjeni");
            UpisIIspisIzBaze.sacuvajUBazuStudenata(Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata, Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeStudenata);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
