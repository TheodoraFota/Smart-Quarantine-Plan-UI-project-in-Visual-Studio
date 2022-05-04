using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ergasia
{
    public partial class ThermometroForm : Form
    {
        double value;

        public ThermometroForm()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void ThermometroForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            timer1.Stop();
            if (value >= 38.0)
            {
                MessageBox.Show($"Η θερμοκρασία σας είναι {value} \n Προτείνεται να κάνετε το τέστ και να απευθυνθείτε στο κοντινότερο διαγνωστικό κέντρο"); 

            }
            else if ( value > 37.2)
            {
                MessageBox.Show($"Η θερμοκρασία σας είναι {value} \n Δεν επιτρέπεται να περάσετε");
            }
            else if ( value > 36.7)
            {
                MessageBox.Show($"Η θερμοκρασία σας είναι {value} \n Δεν επιτρέπεται να περάσετε ξαναδοκιμάστε σε λίγο");
            }
            else
            {
                MessageBox.Show("Μπορείτε να περάσετε");
            }
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Dispose();
            EpilogesSyskeuesSpitiou form = new EpilogesSyskeuesSpitiou();
            this.Hide();
            form.Show();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "59");
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.doorbell_1);
            soundPlayer.Play();
            timer1.Start();
            groupBox1.Visible = true;
            Random rand = new Random();
            value = 36.5 + rand.NextDouble() * (40.5 - 36.5);
            value = Math.Round(value, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
