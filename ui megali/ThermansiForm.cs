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
    public partial class ThermansiForm : Form
    {
        bool ypnodomatio = false;
        bool saloni = false;
        bool ypnodomatio_k = false;
        bool saloni_k = false;
        bool mpanio_k = false;
        public ThermansiForm()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.AC_closed;
            pictureBox2.Image = Properties.Resources.AC_closed;
            pictureBox1.BackColor = Color.OrangeRed;
            pictureBox2.BackColor = Color.OrangeRed;
            pictureBox3.Image = Properties.Resources.radiatoroff;
            pictureBox4.Image = Properties.Resources.radiatoroff;
            pictureBox5.Image = Properties.Resources.radiatoroff;
            pictureBox3.BackColor = Color.OrangeRed;
            pictureBox4.BackColor = Color.OrangeRed;
            pictureBox5.BackColor = Color.OrangeRed;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            if (ypnodomatio)
            {
                pictureBox1.Image = Properties.Resources.AC_closed;
                pictureBox1.BackColor = Color.OrangeRed;
                ypnodomatio = false;
                MessageBox.Show("΄Το κλιματιστικό στο υπνοδωμάτιο έσβησε");

            }
            else
            {
                pictureBox1.Image = Properties.Resources.ac_open;
                pictureBox1.BackColor = Color.LightGreen;
                ypnodomatio = true;
                MessageBox.Show("Το κλιματιστικό στο υπνοδωμάτιο άναψε");

            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (saloni)
            {
                pictureBox2.Image = Properties.Resources.AC_closed;
                pictureBox2.BackColor = Color.OrangeRed;
                saloni = false;
                MessageBox.Show("Το κλιματιστικό στο σαλόνι έσβησε");

            }
            else
            {
                pictureBox2.Image = Properties.Resources.ac_open;
                pictureBox2.BackColor = Color.LightGreen;
                saloni = true;
                MessageBox.Show("Το κλιματιστικό στο σαλόνι άναψε");

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ypnodomatio_k)
            {
                pictureBox3.Image = Properties.Resources.radiatoroff;
                pictureBox3.BackColor = Color.OrangeRed;
                ypnodomatio_k = false;
                MessageBox.Show("Το καλοριφέρ στο υπνοδωμάτιο έσβησε");

            }
            else
            {
                pictureBox3.Image = Properties.Resources.radiatoron;
                pictureBox3.BackColor = Color.LightGreen;
                ypnodomatio_k = true;
                MessageBox.Show("Το καλοριφέρ στο υπνοδωμάτιο άναψε");

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (saloni_k)
            {
                pictureBox4.Image = Properties.Resources.radiatoroff;
                pictureBox4.BackColor = Color.OrangeRed;
                saloni_k = false;
                MessageBox.Show("Το καλοριφέρ στο σαλόνι έσβησε");

            }
            else
            {
                pictureBox4.Image = Properties.Resources.radiatoron;
                pictureBox4.BackColor = Color.LightGreen;
                saloni_k = true;
                MessageBox.Show("Το καλοριφέρ στο σαλόνι άναψε");

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (mpanio_k)
            {
                pictureBox5.Image = Properties.Resources.radiatoroff;
                pictureBox5.BackColor = Color.OrangeRed;
                mpanio_k = false;
                MessageBox.Show("Το καλοριφέρ στο μπάνιο έσβησε");

            }
            else
            {
                pictureBox5.Image = Properties.Resources.radiatoron;
                pictureBox5.BackColor = Color.LightGreen;
                mpanio_k = true;
                MessageBox.Show("Το καλοριφέρ στο μπάνιο άναψε");

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Gray;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Black;
            radioButton1.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }

            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EpilogesSyskeuesSpitiou form = new EpilogesSyskeuesSpitiou();
            this.Hide();
            form.Show();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "47");
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

   
    }
}
