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
    public partial class BoithiaSeIlikiomenous : Form
    {
        public BoithiaSeIlikiomenous()
        {
            InitializeComponent();
            timer1.Start();
            groupBox1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.old_man;
            groupBox1.Visible = true;
            timer1.Stop();
            timer2.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EpilogesIlikiomenonForm form = new EpilogesIlikiomenonForm();
            this.Hide();
            form.Show();
            timer1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            pictureBox1.Visible = false;
            MessageBox.Show("Εντάξει. Ευχαριστούμε Πολύ!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arxiki form = new Arxiki();
            this.Hide();
            form.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Ειδοποιήθήκαν Ο Δήμος Και οι Συγγενείς. 'Ερχεται ασθενοφόρο");
            timer2.Stop();
            Application.Exit();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "62");
            timer1.Dispose();
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
            timer1.Dispose();
        }

        private void BoithiaSeIlikiomenous_Load(object sender, EventArgs e)
        {

        }
    }
}
