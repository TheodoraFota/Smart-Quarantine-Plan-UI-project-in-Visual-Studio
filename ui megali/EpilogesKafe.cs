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
    public partial class EpilogesKafe : Form
    {
        public EpilogesKafe()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Gray;
            this.BackgroundImage = Properties.Resources.mikel;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Gray;
            radioButton2.ForeColor = Color.Black;
            this.BackgroundImage = Properties.Resources.coffee_island;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            button2.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


            if (radioButton1.Checked)
            {
                
                pictureBox1.Image = Properties.Resources.mikel_coffee;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.coffeeisland_co;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(-1) || comboBox2.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Παρακαλούμε επιλέξτε από όλα τα πεδία!");
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                button3.Visible = true;
                pictureBox1.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Παρακαλούμε εισάγετε τον αριθμό της κάρτας σας!");
            }
            else if (textBox1.TextLength < 4)
            {
                MessageBox.Show("Παρακαλούμε εισάγετε σωστά τα στοιχεία της κάρτας σας! Πρέπει να εισάγετε πάνω από 3 αριθμούς!");
            }
            else
            {
                MessageBox.Show("Η πληρωμή ολοκληρωθηκε με επιτυχία!");
                pictureBox2.Visible = true;
                label3.Visible = true;
                pictureBox2.Image = Properties.Resources.klepsidra1;
                groupBox3.Visible = false;
                timer1.Start();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProtinomenesDiadromes f4 = new ProtinomenesDiadromes();
            this.Hide();
            f4.Show();
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Epilogi2 epilogi2 = new Epilogi2();
            this.Hide();
            epilogi2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "21");
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
