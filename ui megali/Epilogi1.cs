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
    public partial class Epilogi1 : Form
    {
        public Epilogi1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Epilogi2 f3 = new Epilogi2();
                this.Hide();
                f3.Show();
            }
            else
            {
                ProtinomenesDiadromes f4 = new ProtinomenesDiadromes();
                this.Hide();
                f4.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DiadromiForm form = new DiadromiForm();
            this.Hide();
            form.Show();
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



        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "14");
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

    }
}
