using StudentskaSluzbaWF5._1;
using StudentskaSluzbaWF6._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentskaSluzbaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata =
                UpisIIspisIzBaze.ucitajBazuStudenata(Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeStudenata);

            Fajl_metoda_koje_rade_sa_studentom.listaIspitaIsit =
                UpisIIspisIzBaze.ucitajBazuIspita(Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeIspitaISIT);

            Fajl_metoda_koje_rade_sa_studentom.listaIspitaMenadzment =
                UpisIIspisIzBaze.ucitajBazuIspita(Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeIspitaMenadzment);

            Fajl_metoda_koje_rade_sa_studentom.listaIspitaOperacioniMenadzment =
                UpisIIspisIzBaze.ucitajBazuIspita(Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeIspitaOperacioniMenadzment);

            Fajl_metoda_koje_rade_sa_studentom.listaIspitaMenadzmentKvaliteta =
                UpisIIspisIzBaze.ucitajBazuIspita(Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeIspitaMenadzmentKvaliteta);

        }
        public void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Ponovno prikazivanje Forme 1 kada se druga forma zatvori
        }



        private void button1_Click(object sender, EventArgs e)
        {




            FRMDaLiZeliteJosNesto daIliNe = new FRMDaLiZeliteJosNesto();

            FormaUpis FRMOsnovnihPodatakaLica = new FormaUpis();

            FormaPrikazPodatkaStudenata FPPS = new FormaPrikazPodatkaStudenata();

            FormaUnosIndeksa FUI = new FormaUnosIndeksa();

            Prikaz_svih_predmeta PSP = new Prikaz_svih_predmeta();

            Student student;

            if (comboBox1.SelectedItem != null)
            {
                // Dobijanje odabrane stavke
                string selectedItem = comboBox1.SelectedItem.ToString();

                // Provera koja je stavka odabrana i pokretanje odgovarajuće forme
                switch (selectedItem)
                {

                    case "Želim da upišem višu godinu":

                        this.Hide();

                        FUI.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        FUI.ShowDialog();

                        Student s1 = FUI.student;
                        this.Hide();
                        UpisViseGodine UVG = new UpisViseGodine(s1);
                        UVG.FormClosed += new FormClosedEventHandler(ChildFormClosed);



                        UVG.ShowDialog();



                        break;

                    case "Želim da se upišem na fakultet":


                        this.Hide();
                        FRMOsnovnihPodatakaLica.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        FRMOsnovnihPodatakaLica.ShowDialog();

                        //FRMDaLiZeliteJosNesto daIliNe = new FRMDaLiZeliteJosNesto();
                        //daIliNe.ShowDialog();

                        break;

                    case "Imena i indeksi upisanih studenata":


                        this.Hide();
                        FPPS.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        FPPS.ShowDialog();


                        //daIliNe.ShowDialog();

                        break;


                    case "Promena podataka upisanog studenta":

                        //  MessageBox.Show("Promena podataka upisanog studenta");

                        this.Hide();
                        FUI.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        FUI.ShowDialog();
                        Student s = FUI.student;

                        if (s != null)
                        {

                            Promena_podataka_upsanog_studenta PPUS = new Promena_podataka_upsanog_studenta(s);

                            if (PPUS.ShowDialog() == DialogResult.OK)
                            {

                                UpisIIspisIzBaze.sacuvajUBazuStudenata(Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata, Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeStudenata);
                                //MessageBox.Show("Menjali podatke ili ne, svakako su sacuvani uspesno u bazi ");
                            }
                        }

                        //daIliNe.ShowDialog();

                        break;

                    case "Prijava ispita":

                        MessageBox.Show("Prijava ispita");
                        break;


                    case "Želim da se ispišem sa fakulteta":

                        this.Hide();
                        FUI.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        FUI.ShowDialog();
                        Student s2 = FUI.student;

                        if (s2 != null)
                        {

                            Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata.Remove(s2);

                            UpisIIspisIzBaze.sacuvajUBazuStudenata(Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata, Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeStudenata);
                            MessageBox.Show("Student je ispisan sa fakulteta");

                        }

                        //daIliNe.ShowDialog();

                        break;


                    case "Lista ispita po smerovima":


                        this.Hide();

                        FormaOdabirSmera FOS = new FormaOdabirSmera();

                        FOS.FormClosed += new FormClosedEventHandler(ChildFormClosed);

                        if (FOS.ShowDialog() == DialogResult.OK)
                        {
                            string smer = FOS.odabraniSmer;

                            Prikaz_svih_predmeta PSP1 = new Prikaz_svih_predmeta(smer);
                            PSP1.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                            PSP1.ShowDialog();

                        }



                        //daIliNe.ShowDialog();

                        break;


                    case "Želim da odaberem predmete za slušanje":

                        this.Hide();
                        FUI.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        FUI.ShowDialog();
                        student = FUI.student;
                        if (student != null)
                        {
                            OdabirPredmetaZaSlusanje OPZS = new OdabirPredmetaZaSlusanje(student);
                            OPZS.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                            OPZS.ShowDialog();

                        }


                        // daIliNe.ShowDialog();

                        break;


                    case "Želim da vidim sve podatke upisanog studenta":
                        this.Hide();
                        FUI.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        FUI.ShowDialog();
                        student = FUI.student;

                        if (student != null)
                        {

                            PrikazSvihPodatakaStudenta PSPS = new PrikazSvihPodatakaStudenta(student);
                            PSPS.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                            PSPS.ShowDialog();

                        }


                        //daIliNe.ShowDialog();

                        break;

                    case "Želim da polažem ispit":
                        FUI.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        this.Hide();
                        FUI.ShowDialog();
                        student = FUI.student;

                        if (student != null)
                        {
                            PolaganjeIspita PI = new PolaganjeIspita(student);
                            PI.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                            PI.ShowDialog();

                        }



                        //daIliNe.ShowDialog();


                        break;


                    default:
                        MessageBox.Show("Molimo izaberite neku ponudjenu opciju");
                        break;

                    case "Želim da napustim program":
                        this.Hide();
                        MessageBox.Show("Studentska služba vas pozdravlja");
                        Environment.Exit(0);

                        break;
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite jednu od ponudjenih stavki");
            }




            this.DialogResult = DialogResult.OK;



        }

        private void button3_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }


    }
}
