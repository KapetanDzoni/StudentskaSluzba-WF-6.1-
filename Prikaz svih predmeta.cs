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
    public partial class Prikaz_svih_predmeta : Form
    {

        private string smer="";
        public Prikaz_svih_predmeta()
        {
            InitializeComponent();
            prikaziPredmete();
        }

        public Prikaz_svih_predmeta(string konstruktorSmer)
        {
            
            InitializeComponent();
            smer = konstruktorSmer;
            prikaziPredmete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }


        private void prikaziPredmete()
        {
            if (smer.Equals("Informacioni sistemi i tehnologije"))
            {

                if (Fajl_metoda_koje_rade_sa_studentom.listaIspitaIsit.Count == 0)
                {
                    MessageBox.Show("lista ispita za ISIT je prazna");
                }
                string zaPrikaz;
                int brojac = 1;
                foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaIsit)
                {

                    ListViewItem ispit = new ListViewItem(brojac.ToString() + ".");

                    ispit.SubItems.Add(i.Naziv);
                    ispit.SubItems.Add(i.ESPB.ToString());
                    ispit.SubItems.Add(i.Godina.ToString());

                    listView1.Items.Add(ispit);
                    brojac++;

                }
                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }

            if (smer.Equals("Menadžment"))
            {

                string zaPrikaz;
                int brojac = 1;

                if (Fajl_metoda_koje_rade_sa_studentom.listaIspitaMenadzment.Count==0 )
                {
                     MessageBox.Show ( "lista ispita za Menadzment je prazna");
                }
                foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaMenadzment)
                {

                    ListViewItem ispit = new ListViewItem(brojac.ToString() + ".");

                    ispit.SubItems.Add(i.Naziv);
                    ispit.SubItems.Add(i.ESPB.ToString());
                    ispit.SubItems.Add(i.Godina.ToString());

                    listView1.Items.Add(ispit);
                    brojac++;

                }
                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }
            if (smer.Equals("Operacioni menadžment"))
            {

                string zaPrikaz;
                int brojac = 1;

                if (Fajl_metoda_koje_rade_sa_studentom.listaIspitaOperacioniMenadzment.Count == 0)
                {
                    MessageBox.Show("lista ispita za Operacioni menadzment je prazna");
                }
                foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaOperacioniMenadzment)
                {

                    ListViewItem ispit = new ListViewItem(brojac.ToString() + ".");

                    ispit.SubItems.Add(i.Naziv);
                    ispit.SubItems.Add(i.ESPB.ToString());
                    ispit.SubItems.Add(i.Godina.ToString());

                    listView1.Items.Add(ispit);
                    brojac++;

                }
                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }


            

             if (smer.Equals("Menadžment kvaliteta i standardizacija"))
            {

                string zaPrikaz;
                int brojac = 1;

                if (Fajl_metoda_koje_rade_sa_studentom.listaIspitaMenadzmentKvaliteta.Count == 0)
                {
                    MessageBox.Show("lista ispita za  menadzment kvaliteta je prazna");
                }
                foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaMenadzmentKvaliteta)
                {

                    ListViewItem ispit = new ListViewItem(brojac.ToString() + ".");

                    ispit.SubItems.Add(i.Naziv);
                    ispit.SubItems.Add(i.ESPB.ToString());
                    ispit.SubItems.Add(i.Godina.ToString());

                    listView1.Items.Add(ispit);
                    brojac++;

                }
                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }
        }


    }
}
