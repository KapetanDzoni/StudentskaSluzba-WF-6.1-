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

namespace StudentskaSluzbaWF5._1
{
    public partial class OdabirViseGodineStudija : Form
    {
        private Student S1;

        public OdabirViseGodineStudija()
        {
            InitializeComponent();
        }

        public OdabirViseGodineStudija(Student S)
        {
            S1 = S;
            InitializeComponent();
            //CentrirajLabelu(label2, label3);
            label2.Text = prikaziGodinuKojuMozeDaUpise(S);
            label5.Text = Fajl_metoda_koje_rade_sa_studentom.brojOstvarenihESPBBodova(S).ToString();
        }
        private void CentrirajLabelu(Label label, Label label2)
        {
           
            int centerX = (this.ClientSize.Width - label.Width) / 2;
            int centerY = (this.ClientSize.Height - label.Height) / 2;

            
            label.Location = new Point(centerX, centerY);

            int label2X = label2.Right + 5; 
            int label2Y = centerY; 
            label2.Location = new Point(label2X, label2Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string stara = S1.GodinaStudija.ToString();
            S1.GodinaStudija = Fajl_metoda_koje_rade_sa_studentom.daLiStudentIspunjavaUslovZaUpisViseGodine(S1);

            MessageBox.Show("Čestitamo na upisu više godine");

            UpisIIspisIzBaze.sacuvajUBazuStudenata(Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata, Fajl_metoda_koje_rade_sa_studentom.lokacijaBazeStudenata);

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

        private string prikaziGodinuKojuMozeDaUpise (Student s)
        {
            int godina = Fajl_metoda_koje_rade_sa_studentom.daLiStudentIspunjavaUslovZaUpisViseGodine (s);
            // MessageBox.Show("Student moze da upise godinu:" + prikaz);
            string zaPrikaz = "";
           if (godina == 2) 
            { zaPrikaz = "Student može da upiše drugu godinu";  }
            if (godina == 3)
            { zaPrikaz = "Student može da upiše treću godinu"; }
            if (godina == 4)
            { zaPrikaz = "Student može da upiše četvrtu godinu"; }

            return zaPrikaz;
        }

        


    }
}
