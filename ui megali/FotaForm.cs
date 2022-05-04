using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ergasia
{
    public partial class FotaForm : Form
    {
        bool ypnodomatio = false;
        bool saloni = false;
        bool koyzina = false;
        bool mpanio = false;
        bool mpalkoni = false;
        public FotaForm()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.lightsoff;
            pictureBox2.Image = Properties.Resources.lightsoff;
            pictureBox3.Image = Properties.Resources.lightsoff;
            pictureBox4.Image = Properties.Resources.lightsoff;
            pictureBox5.Image = Properties.Resources.lightsoff;
        }

        private void FotaForm_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

            if (ypnodomatio)
            {
                pictureBox1.Image = Properties.Resources.lightsoff;
                ypnodomatio = false;
                MessageBox.Show("Τα φώτα στο υπνοδωμάτιο έσβησαν");

            }
            else
            {
                pictureBox1.Image = Properties.Resources.lighton;
                ypnodomatio = true;
                MessageBox.Show("Τα φώτα στο υπνοδωμάτιο άναψαν");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (saloni)
            {
                pictureBox2.Image = Properties.Resources.lightsoff;
                saloni = false;
                MessageBox.Show("Τα φώτα στο σαλόνι έσβησαν");

            }
            else
            {
                pictureBox2.Image = Properties.Resources.lighton;
                saloni = true;
                MessageBox.Show("Τα φώτα στο σαλόνι άναψαν");

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (koyzina)
            {
                pictureBox3.Image = Properties.Resources.lightsoff;
                koyzina = false;
                MessageBox.Show("Τα φώτα στη κουζίνα έσβησαν");

            }
            else
            {
                pictureBox3.Image = Properties.Resources.lighton;
                koyzina = true;
                MessageBox.Show("Τα φώτα στη κουζίνα άναψαν");

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (mpanio)
            {
                pictureBox4.Image = Properties.Resources.lightsoff;
                mpanio = false;
                MessageBox.Show("Τα φώτα στο μπάνιο έσβησαν");

            }
            else
            {
                pictureBox4.Image = Properties.Resources.lighton;
                mpanio = true;
                MessageBox.Show("Τα φώτα στο μπάνιο άναψαν");

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (mpalkoni)
            {
                pictureBox5.Image = Properties.Resources.lightsoff;
                mpalkoni = false;
                MessageBox.Show("Τα φώτα στο μπαλκόνι έσβησαν");

            }
            else
            {
                pictureBox5.Image = Properties.Resources.lighton;
                mpalkoni = true;
                MessageBox.Show("Τα φώτα στο μπαλκόνι άναψαν");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EpilogesSyskeuesSpitiou form = new EpilogesSyskeuesSpitiou();
            this.Hide();
            form.Show();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "51");
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
