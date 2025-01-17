using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzbaWF
{
    public partial class Form3 : Form
    {
        public string odabranaVrstaStudija;
        public string vrstaStudija;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CBVrstaStudija.Text == null || CBVrstaStudija.Text.Length == 0)
            {
                MessageBox.Show("Molimo odaberite vrstu studija");
                return;

            }

            else
            {
              
                odabranaVrstaStudija = CBVrstaStudija.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }
    }
}
