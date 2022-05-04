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
    public partial class ProtinomenesDiadromes : Form
    {
       
        
        public ProtinomenesDiadromes()
        {
            InitializeComponent();
            Random r = new Random();
            
            int value1=r.Next(1, 100);
            int value2=r.Next(1, 100);
            label2.Text = "Σε αυτή την διαδρομή κινούνται " + value1.ToString() + " άτομα";
            label3.Text = "Σε αυτή την διαδρομή κινούνται " + value2.ToString() + " άτομα";

            if (value1 < value2)
            {
              
                label2.ForeColor = Color.Green;
                label3.ForeColor = Color.Red;
                label4.Text = "ΒΕΛΤΙΣΤΗ ΔΙΑΔΡΟΜΗ";
                label5.Text = "ΜΗ ΒΕΛΤΙΣΤΗ ΔΙΑΔΡΟΜΗ";
                label5.ForeColor = Color.Red;
                label4.ForeColor = Color.Green;


                label6.Text = "Προτεινόμενη ώρα επιστροφής: " + User.time.AddHours(5).ToString("hh:mm");
                label7.Text = "Προτεινόμενη ώρα επιστροφής: " + User.time.AddHours(2).ToString("hh:mm");
                label6.ForeColor = Color.Green;
                label7.ForeColor = Color.Red;

                pictureBox7.Image = Properties.Resources.prasino;
            }
            else if (value1 > value2)
            {
                label3.ForeColor = Color.Green;
                label2.ForeColor = Color.Red;
                label5.Text = "ΒΕΛΤΙΣΤΗ ΔΙΑΔΡΟΜΗ";
                label4.Text = "ΜΗ ΒΕΛΤΙΣΤΗ ΔΙΑΔΡΟΜΗ";
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
              
                label7.Text = "Προτεινόμενη ώρα επιστροφής: " + User.time.AddHours(5).ToString("hh:mm"); 
                label6.Text = "Προτεινόμενη ώρα επιστροφής: " + User.time.AddHours(2).ToString("hh:mm");
                pictureBox6.Image = Properties.Resources.prasino;
                label7.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
            }
        
            else
            {
                label2.ForeColor = Color.Green;
                label3.ForeColor = Color.Green;
                label4.Text = "ΚΑΙ ΟΙ ΔΥΟ ΔΙΑΔΡΟΜΕΣ ΕΙΝΑΙ ΒΕΛΤΙΣΤΕΣ";
                label4.ForeColor = Color.Green;
                label5.Text = "ΚΑΙ ΟΙ ΔΥΟ ΔΙΑΔΡΟΜΕΣ ΕΙΝΑΙ ΒΕΛΤΙΣΤΕΣ";
                label5.ForeColor = Color.Green;

                label6.Text = "Προτεινόμενη ώρα επιστροφής: " + User.time.AddHours(5).ToString("hh:mm");
                label7.Text = "Προτεινόμενη ώρα επιστροφής: " + User.time.AddHours(5).ToString("hh:mm");
                pictureBox6.Image = Properties.Resources.prasino;
                pictureBox7.Image = Properties.Resources.prasino;
                label6.ForeColor = Color.Green;
                label7.ForeColor = Color.Green;
            }
        


            if (User.work)
            {
                pictureBox1.Image = Properties.Resources.diadromi_work;
               
                pictureBox2.Image = Properties.Resources.diadromi_work2;
            }
            if (User.gym)
            {
                pictureBox1.Image = Properties.Resources.diadromi_gym;
                pictureBox2.Image = Properties.Resources.diadromi_gym2;
            }
            if (User.super_market)
            {
                pictureBox1.Image = Properties.Resources.diadromi_market;
                pictureBox2.Image = Properties.Resources.diadromi_market2;
            }
            if (User.bycicle)
            {
                pictureBox4.Image = Properties.Resources.bicycle;
               
            }
            if (User.onfoot)
            {
                pictureBox4.Image = Properties.Resources.walking;

            }
            if (User.car)
            {
                pictureBox4.Image = Properties.Resources.car;

            }
            if (User.bus)
            {
                pictureBox5.Image = Properties.Resources.bus;

            }
            if (User.metro)
            {
                pictureBox3.Image = Properties.Resources.metro;

            }


        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

          
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiadromiForm form = new DiadromiForm();
            this.Hide();
            form.Show();
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");

        }


        private void βοήθειαToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "29");
        }
    }
}
