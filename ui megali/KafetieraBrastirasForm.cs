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
    public partial class KafetieraBrastirasForm : Form
    {
        public KafetieraBrastirasForm()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.kaf3;
            pictureBox2.Image = Properties.Resources.vrastiras1;

        }

        private void KafetieraBrastirasForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kafetiera1;
            MessageBox.Show("Η καφετιέρα ξεκίνησε να λειτουργεί");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kafetiera2;
            MessageBox.Show("Ο καφές σας είναι έτοιμος");
            timer1.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο βραστήρας ξεκίνησε να λειτουργεί");
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            pictureBox2.Image = Properties.Resources.vrastiras2;
            timer2.Stop();
            MessageBox.Show("Το νερό έβρασε");
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EpilogesSyskeuesSpitiou form = new EpilogesSyskeuesSpitiou();
            this.Hide();
            form.Show();
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "41");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
