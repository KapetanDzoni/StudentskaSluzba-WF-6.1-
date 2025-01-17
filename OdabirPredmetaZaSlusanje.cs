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
    public partial class OdabirPredmetaZaSlusanje : Form
    {
        private Student student;

        public OdabirPredmetaZaSlusanje()
        {
            InitializeComponent();

        }

        public OdabirPredmetaZaSlusanje(Student student)
        {
            InitializeComponent();
            this.student = student;

            // prikaziPredmeteKojeStudentMozeDaSlusa();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);

            prikaziPredmeteKojeStudentMozeDaSlusa2();
            

        }


        void prikaziPredmeteKojeStudentMozeDaSlusa2()
        {
            string zaPrikaz;
            int brojac = 1;

            if (student.Smer == "Informacioni sistemi i tehnologije")
            {
                foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaIsit)
                {
                    if (student.GodinaStudija >= i.Godina)
                    {
                        // if (!student.listaOdabranihIspita.Any(x => x.Naziv == i.Naziv && x.Godina == i.Godina && x.ESPB== i.ESPB))
                        if (!student.listaOdabranihIspita.Contains(i))
                        {
                            if (!Fajl_metoda_koje_rade_sa_studentom.daLiJeStudentVecPolozioIspit(student, i))
                            {



                                ListViewItem ispit = new ListViewItem(brojac.ToString() + ".");

                                ispit.SubItems.Add(i.Naziv);
                                ispit.SubItems.Add(i.ESPB.ToString());
                                ispit.SubItems.Add(i.Godina.ToString());

                                listView1.Items.Add(ispit);
                                brojac++;

                            }
                        }

                    }
                }
                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }

            if (student.Smer == "Menadžment")
            {
                foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaMenadzment)
                {
                    if (student.GodinaStudija >= i.Godina)
                    {
                        // if (!student.listaOdabranihIspita.Any(x => x.Naziv == i.Naziv && x.Godina == i.Godina && x.ESPB== i.ESPB))
                        if (!student.listaOdabranihIspita.Contains(i))
                        {
                            if (!Fajl_metoda_koje_rade_sa_studentom.daLiJeStudentVecPolozioIspit(student, i))
                            {



                                ListViewItem ispit = new ListViewItem(brojac.ToString() + ".");

                                ispit.SubItems.Add(i.Naziv);
                                ispit.SubItems.Add(i.ESPB.ToString());
                                ispit.SubItems.Add(i.Godina.ToString());

                                listView1.Items.Add(ispit);
                                brojac++;

                            }
                        }

                    }
                }
                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }

            if (student.Smer == "Operacioni menadžment")
            {
                foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaOperacioniMenadzment)
                {
                    if (student.GodinaStudija >= i.Godina)
                    {
                        // if (!student.listaOdabranihIspita.Any(x => x.Naziv == i.Naziv && x.Godina == i.Godina && x.ESPB== i.ESPB))
                        if (!student.listaOdabranihIspita.Contains(i))
                        {
                            if (!Fajl_metoda_koje_rade_sa_studentom.daLiJeStudentVecPolozioIspit(student, i))
                            {



                                ListViewItem ispit = new ListViewItem(brojac.ToString() + ".");

                                ispit.SubItems.Add(i.Naziv);
                                ispit.SubItems.Add(i.ESPB.ToString());
                                ispit.SubItems.Add(i.Godina.ToString());

                                listView1.Items.Add(ispit);
                                brojac++;

                            }
                        }

                    }
                }
                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }

            if (student.Smer == "Menadžment kvaliteta i standardizacija")
            {
                foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaMenadzmentKvaliteta)
                {
                    if (student.GodinaStudija >= i.Godina)
                    {
                        // if (!student.listaOdabranihIspita.Any(x => x.Naziv == i.Naziv && x.Godina == i.Godina && x.ESPB== i.ESPB))
                        if (!student.listaOdabranihIspita.Contains(i))
                        {
                            if (!Fajl_metoda_koje_rade_sa_studentom.daLiJeStudentVecPolozioIspit(student, i))
                            {



                                ListViewItem ispit = new ListViewItem(brojac.ToString() + ".");

                                ispit.SubItems.Add(i.Naziv);
                                ispit.SubItems.Add(i.ESPB.ToString());
                                ispit.SubItems.Add(i.Godina.ToString());

                                listView1.Items.Add(ispit);
                                brojac++;

                            }
                        }

                    }
                }
                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2; // -2 automatsko prilagodjavanje sirine kolne
                }

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem selektovano = listView1.SelectedItems[0];

                // Pristupi koloni "Naziv" (druga kolona, indeks 1)
                string nazivOdabranogIspita = selektovano.SubItems[1].Text;



                Ispit i = Fajl_opstih_metoda.pronadjiIspitPoImenu(nazivOdabranogIspita);
                //Fajl_opstih_metoda.PrikaziSveElemente(i);
                if (i != null)
                {

                    int prethodniBrojIspita = student.listaOdabranihIspita.Count;
                    student.listaOdabranihIspita.Add(i);


                    if (student.listaOdabranihIspita.Count > prethodniBrojIspita)
                    {
                        MessageBox.Show("Ispit " + nazivOdabranogIspita + " je odabran za slušanje");
                    }
                    // MessageBox.Show("Uspešno ste prijavili ispit za slušanje:"+i.ToString());

                    UpisIIspisIzBaze.sacuvajUBazuStudenata(Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata, Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeStudenata);
                }
                else
                {
                    MessageBox.Show("ISPIT NIJE DODAT U LISTU ODABRANIH ISPITA");
                }

            }
            else
            {
                MessageBox.Show("Molimo vas odaberite ispit koji želite da prijavite za slušanje");
                return;
            }


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
