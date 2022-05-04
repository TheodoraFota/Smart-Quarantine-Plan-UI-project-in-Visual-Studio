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
    public partial class Epilogi2 : Form
    {
        public Epilogi2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                EpilogesKafe f5 = new EpilogesKafe();
                this.Hide();
                f5.Show();
                
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Μπορείτε να κάνετε στάση για καφέ στο κατάστημα Μikel στην οδό: Εμμανουήλ Μπενάκη 7 ή Coffee Island  Αιόλου 64!");
                ProtinomenesDiadromes f4 = new ProtinomenesDiadromes();
                this.Hide();
                f4.Show();
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Epilogi1 form = new Epilogi1();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Gray;
        }

    

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

            radioButton2.ForeColor = Color.Black;
            radioButton1.ForeColor = Color.Gray;
        }


        private void βοήθειαToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "19");

        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }
    }
}
