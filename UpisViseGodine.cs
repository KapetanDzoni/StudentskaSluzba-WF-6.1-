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
    public partial class UpisViseGodine : Form
    {
        private Student SPriv;
        public UpisViseGodine()
        {
            InitializeComponent();
        }

        public UpisViseGodine(Student S)
        {
            SPriv = S;
            InitializeComponent();
            label1.Text = S.ImeIPrezime;
            label2.Text = S.BrojIndeksa;
            label3.Text = "Upisana godina: " + S.GodinaStudija;
            label4.Text = uslov(S);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fajl_metoda_koje_rade_sa_studentom.daLiStudentIspunjavaUslovZaUpisViseGodine(SPriv) > SPriv.GodinaStudija)
            {
  
               this.Hide();

               OdabirViseGodineStudija OVGS = new OdabirViseGodineStudija(SPriv);
               
                OVGS.ShowDialog();
            }

            DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }

        private string uslov(Student S)
        {
            if (Fajl_metoda_koje_rade_sa_studentom.daLiStudentIspunjavaUslovZaUpisViseGodine(S) > S.GodinaStudija)
            {
                return "Student ispunjava uslov za upis u višu godinu studija";
            }

            return "Student ne ispunjava uslov za upis više godine studija";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();

        }

        
    }
}
