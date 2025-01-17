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
    public partial class FormaOdabirSmera : Form
    {

        public string odabraniSmer;
        public FormaOdabirSmera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CBSmer.SelectedItem.ToString() == null || CBSmer.SelectedItem.ToString().Length == 0)
            {
                MessageBox.Show("Molimo odaberite smer");
                return;
            }
            else
            {

                odabraniSmer = CBSmer.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }
    }
}
