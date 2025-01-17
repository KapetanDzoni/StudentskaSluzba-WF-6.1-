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
    public partial class PrikazSvihPodatakaStudenta : Form
    {
        private Student student;
        public PrikazSvihPodatakaStudenta()
        {
            InitializeComponent();
        }

        public PrikazSvihPodatakaStudenta(Student student)
        {

            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            listView2.GridLines = true;

            this.student = student;

            TBImePrezime.Text = student.ImeIPrezime;
            TBImeRoditelja.Text = student.ImeRoditelja;
            TBDatumRodjenja.Text = student.DatumRodjenja;
            TBDrzava.Text = student.DrzavaRodjenja;
            TBDrzavljanstvo.Text = student.Drzavljanstvo;
            TBJMBG.Text = student.Jmbg;
            TBOpstinaRodjenja.Text = student.OpstinaRodjenja;
            TBVrstaStudija.Text = student.VrstaStudija;
            TBSmer.Text = student.Smer;
            TBGodinaStudija.Text = student.GodinaStudija.ToString();
            textBox1.Text = student.BrojIndeksa;

            prikaziSvePredmeteZaSlusanje();

            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);

            prikaziSvePolozenePredmete();

            TBProsek.Text = Fajl_metoda_koje_rade_sa_studentom.izracunajProsekStudenta(student);

            listView2.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void prikaziSvePredmeteZaSlusanje()
        {
            string zaPrikaz;
            if (student.listaOdabranihIspita.Count == 0)
            {
                listView1.Items.Add("Student nije položio ni jedan ispit");
                return;
            }

            int brojac = 1;

            foreach (Ispit I in student.listaOdabranihIspita)
            {

                ListViewItem LV1 = new ListViewItem(brojac.ToString() + ".");

                LV1.SubItems.Add(I.Naziv);
                LV1.SubItems.Add(I.ESPB.ToString());
                LV1.SubItems.Add(I.Godina.ToString());


                listView1.Items.Add(LV1);
                brojac++;


                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }
        }
        private void prikaziSvePolozenePredmete()
        {
            string zaPrikaz;
            if (student.listaPolozenihIspita.Count == 0)
            {
                listView2.Items.Add("Student nije položio ni jedan ispit");
                return;
            }
            int brojac = 1;
            foreach (PolozeniIspit PI in student.listaPolozenihIspita)
            {

                ListViewItem LV2 = new ListViewItem(brojac.ToString() + ".");

                LV2.SubItems.Add(PI.Ispit.Naziv);
                LV2.SubItems.Add(PI.Ispit.ESPB.ToString());
                LV2.SubItems.Add(PI.Ispit.Godina.ToString());
                LV2.SubItems.Add(PI.Ocena.ToString());
                LV2.SubItems.Add(PI.DatumPolaganja.ToString());
                listView2.Items.Add(LV2);
                brojac++;


                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

        

        
    }
}
