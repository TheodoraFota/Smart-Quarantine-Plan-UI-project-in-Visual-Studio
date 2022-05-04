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
    public partial class EpilogesIlikiomenonForm : Form
    {
        public EpilogesIlikiomenonForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Gray;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoithiaSeIlikiomenous form = new BoithiaSeIlikiomenous();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Ο γιατρός ειδοποιήθηκε και θα έρθει σύντομα");
                Application.Exit();

            }
            else
            {
                MessageBox.Show("Είδοποιήθηκε ο Δήμος και θα σας στείλει άτομο για βοήθεια άμεσα");
                Application.Exit();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Black;
            radioButton1.ForeColor = Color.Gray;
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "63");

        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }


    
    }
}
