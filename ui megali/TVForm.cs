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
    public partial class TVForm : Form
    {
        bool on = false;
        public TVForm()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.tvoff;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (on)
            {
                pictureBox1.Image = Properties.Resources.tvoff;
                on = false;
                label1.Text = "Πατήστε πάνω στην τηλεόραση για να την ανοίξετε";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.tvon;
                on = true;

                label1.Text = "Πατήστε πάνω στην τηλεόραση για να την κλείσετε";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EpilogesSyskeuesSpitiou form = new EpilogesSyskeuesSpitiou();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "55");
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

      

    }
}
