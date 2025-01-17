using StudentskaSluzbaWF6._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentskaSluzbaWF
{
    public partial class FormaUpis : Form
    {
        public FormaUpis()
        {
            InitializeComponent();
        }

        public string ImePrezime;
        public string ImePrezimeRoditelja;
        public string datumRodjenja;
        public string drzava;
        public string opstinaRodjenja;
        public string drzavljanstvo;
        public string jmbg;

        private void button1_Click22(object sender, EventArgs e)
        {
            Student s1 = new Student();

            string trenutniDatum = DateTime.Now.ToString("dd.MM.yyyy.");

            //provera da li su podaci upisani i popunjeni 

            if (Validacije_podataka.proveraImenaIPrezimena2(TBImePrezime.Text) &&
                Validacije_podataka.proveraImenaRoditelja(TBImeRoditelja.Text) &&
                Validacije_podataka.proveraDatumaRodjenja(CBDan.Text, CBMesec.Text, CBGodina.Text) &&
                CBDrzava.SelectedIndex != -1 &&
                Validacije_podataka.proveraMestaRodjenja(TBOpstinaRodjenja.Text) &&
                Validacije_podataka.proveraDrzavljanstva(TBDrzavljanstvo.Text) &&
                Validacije_podataka.proveraUnosJMBG(TBJMBG.Text))
            {

                s1.ImeIPrezime = TBImePrezime.Text;

                // s1.ImeIPrezime = Form3.CBVrstaStudija.Text;

                s1.ImeRoditelja = TBImeRoditelja.Text;

                s1.DatumRodjenja = CBDan.Text + CBMesec.Text + CBGodina.Text;

                s1.OpstinaRodjenja = TBOpstinaRodjenja.Text;

                s1.DrzavaRodjenja = CBDrzava.SelectedItem.ToString();

                s1.Drzavljanstvo = TBDrzavljanstvo.Text;

                s1.Jmbg = TBJMBG.Text;

                Form3 FormaOdabirVrsteStudija = new Form3();

                this.Hide();

                FormaOdabirVrsteStudija.ShowDialog();
                if (FormaOdabirVrsteStudija.DialogResult == DialogResult.OK)
                {
                    s1.VrstaStudija = FormaOdabirVrsteStudija.odabranaVrstaStudija;
                    FormaOdabirSmera FOS = new FormaOdabirSmera();

                    FOS.ShowDialog();
                    if (FOS.DialogResult == DialogResult.OK)
                    {
                        s1.Smer = FOS.odabraniSmer;


                        UpisUnosIndeksa UI = new UpisUnosIndeksa();
                        UI.ShowDialog();
                        if (UI.DialogResult == DialogResult.OK)
                        {
                            s1.BrojIndeksa = UI.indeks;
                            s1.DatumUpisa = trenutniDatum.ToString();
                            s1.GodinaStudija = 1;
                        }

                    }

                }

                if (Fajl_opstih_metoda.daLiSuSviPodaciPopunjeni(s1))
                {

                    Fajl_metoda_koje_rade_sa_studentom.upisiStudenta(s1);

                }
                else
                {
                    MessageBox.Show("Nisu popunjeni svi podaci studenta i upis nije izvrsen");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();

            }
            if (CBDrzava.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali svoju državu rodjenja");
            }
            if (String.IsNullOrWhiteSpace(TBOpstinaRodjenja.Text))
            {
                MessageBox.Show("Niste uneli svoju opštinu rodjenja");
            }

            return;

        }

        private bool daLiSuSviPodaciUneseni()
        {

            if (String.IsNullOrWhiteSpace(TBImePrezime.Text))
            {
                MessageBox.Show("Niste uneli svoje ime i prezime");
                return false;
            }
            if (String.IsNullOrWhiteSpace(TBImeRoditelja.Text))
            {
                MessageBox.Show("Niste uneli ime i prezime roditelja");
                return false; ;
            }
            if (String.IsNullOrWhiteSpace(CBDan.Text))
            {
                MessageBox.Show("Niste odabrali dan rodjenja");
                return false; ;
            }

            if (String.IsNullOrWhiteSpace(CBMesec.Text))
            {
                MessageBox.Show("Niste odabrali mesec rodjenja");
                return false; ;
            }
            if (String.IsNullOrWhiteSpace(CBGodina.Text))
            {
                MessageBox.Show("Niste odabrali godinu rodjenja");
                return false; ;
            }
            if (CBDrzava.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali državu rodjenja");
                return false; ;
            }
            if (String.IsNullOrWhiteSpace(TBOpstinaRodjenja.Text))
            {
                MessageBox.Show("Niste uneli opštinu rodjenja");
                return false; ;
            }
            if (String.IsNullOrWhiteSpace(TBDrzavljanstvo.Text))
            {
                MessageBox.Show("Niste uneli svoje državljanstvo");
                return false; ;
            }
            if (String.IsNullOrWhiteSpace(TBJMBG.Text))
            {
                MessageBox.Show("Niste uneli svoj jedinstveni matični broj gradjana");
                return false; ;
            }
            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (daLiSuSviPodaciUneseni())
            {
                if (Validacije_podataka.proveraImenaIPrezimena2(TBImePrezime.Text) &&
                    Validacije_podataka.proveraImenaRoditelja(TBImeRoditelja.Text) &&
                    Validacije_podataka.proveraDatumaRodjenja(CBDan.Text, CBMesec.Text, CBGodina.Text) &&
                    Validacije_podataka.proveraMestaRodjenja(TBOpstinaRodjenja.Text) &&
                    Validacije_podataka.proveraDrzavljanstva(TBDrzavljanstvo.Text) &&
                    Validacije_podataka.proveraUnosJMBG(TBJMBG.Text))
                {
                    Student s1 = new Student();

                    string trenutniDatum = DateTime.Now.ToString("dd.MM.yyyy.");


                    s1.ImeIPrezime = TBImePrezime.Text;

                    s1.ImeRoditelja = TBImeRoditelja.Text;

                    s1.DatumRodjenja = CBDan.Text + CBMesec.Text + CBGodina.Text;

                    s1.OpstinaRodjenja = TBOpstinaRodjenja.Text;

                    s1.DrzavaRodjenja = CBDrzava.SelectedItem.ToString();

                    s1.Drzavljanstvo = TBDrzavljanstvo.Text;

                    s1.Jmbg = TBJMBG.Text;


                    Form3 FormaOdabirVrsteStudija = new Form3();

                    this.Hide();

                    FormaOdabirVrsteStudija.ShowDialog();
                    if (FormaOdabirVrsteStudija.DialogResult == DialogResult.OK)
                    {
                        s1.VrstaStudija = FormaOdabirVrsteStudija.odabranaVrstaStudija;
                        FormaOdabirSmera FOS = new FormaOdabirSmera();

                        FOS.ShowDialog();
                        if (FOS.DialogResult == DialogResult.OK)
                        {
                            s1.Smer = FOS.odabraniSmer;


                            UpisUnosIndeksa UI = new UpisUnosIndeksa();
                            UI.ShowDialog();
                            if (UI.DialogResult == DialogResult.OK)
                            {
                                s1.BrojIndeksa = UI.indeks;
                                s1.DatumUpisa = trenutniDatum.ToString();
                                s1.GodinaStudija = 1;
                            }

                        }

                    }

                    if (Fajl_opstih_metoda.daLiSuSviPodaciPopunjeni(s1))
                    {

                        Fajl_metoda_koje_rade_sa_studentom.upisiStudenta(s1);

                    }
                    else
                    {
                        //MessageBox.Show("Nisu popunjeni svi podaci studenta i upis nije izvrsen");
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    this.Dispose();

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public bool proveraUnetostiSvihPodatakaStudenta()
        {
            if (string.IsNullOrEmpty(TBImePrezime.Text))
            {
                MessageBox.Show("\nNiste uneli svoje ime i prezime");
                return false;
            }
            if (string.IsNullOrEmpty(TBImeRoditelja.Text))
            {
                MessageBox.Show("\nNiste uneli ime i prezime roditelja");
                return false;
            }

            if (CBDan.SelectedItem == null)
            {
                MessageBox.Show("\nNiste uneli dan svog rodjenja ");
                return false;
            }
            if (CBMesec.SelectedItem == null)
            {
                MessageBox.Show("\nNiste uneli dan svog rodjenja ");
                return false;
            }
            if (CBGodina.SelectedItem == null)
            {
                MessageBox.Show("\nNiste uneli dan svog rodjenja ");
                return false;
            }

            if (CBDrzava.SelectedItem == null)
            {
                MessageBox.Show("\nNiste odabrali svoju državu rodjenja ");
                return false;
            }

            if (string.IsNullOrEmpty(TBDrzavljanstvo.Text))
            {
                MessageBox.Show("\nNiste uneli svoj svoje državljanstvo rodjenja ");
                return false;
            }

            if (string.IsNullOrEmpty(TBJMBG.Text))
            {
                MessageBox.Show("\nNiste uneli svoj JMBG ");
                return false;
            }

            //MessageBox.Show("\n         Svi podaci su uneseni!!! ");
            return true;
        }


    }



}
