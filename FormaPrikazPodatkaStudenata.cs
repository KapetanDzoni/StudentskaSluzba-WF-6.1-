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
    public partial class FormaPrikazPodatkaStudenata : Form
    {
        public FormaPrikazPodatkaStudenata()
        {
            InitializeComponent();
            prikaziStudente();

        }

        public void prikaziStudente()
        {
            int i = 1;
            string zaPrikaz;
            if (Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata.Count == 0)
            {
                listBox1.Items.Add("Lista upisanih studenata je prazna");
            }

            foreach (Student s in Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata)
            {
                zaPrikaz = i + ". " + Fajl_opstih_metoda.pripremaPodatkaZaPrikaz(s);
                listBox1.Items.Add(zaPrikaz);
                i++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }
    }
}
