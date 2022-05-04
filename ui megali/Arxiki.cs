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
    public partial class Arxiki : Form
    {
        public Arxiki()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Gray;
            radioButton3.ForeColor = Color.Gray;
            radioButton2.ForeColor = Color.Black;
            



        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Gray;
            radioButton3.ForeColor = Color.Gray;
            radioButton1.ForeColor = Color.Black;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DiadromiForm form = new DiadromiForm();
                this.Hide();
                form.Show();
            }
            else if (radioButton2.Checked)
            {
                EpilogesSyskeuesSpitiou form = new EpilogesSyskeuesSpitiou();
                this.Hide();
                form.Show();
            }
            else
            {
                BoithiaSeIlikiomenous form = new BoithiaSeIlikiomenous(); ;
                this.Hide();
                form.Show();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Gray;
            radioButton1.ForeColor = Color.Gray;
            radioButton3.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm" ,HelpNavigator.TopicId, "1");
        }
    }
}
