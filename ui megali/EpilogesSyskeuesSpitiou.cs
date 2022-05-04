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
    public partial class EpilogesSyskeuesSpitiou : Form
    {
        public EpilogesSyskeuesSpitiou()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FotaForm fotaForm = new FotaForm();
                this.Hide();
                fotaForm.Show();
            }
            else if (radioButton2.Checked)
            {
                ThermansiForm thermansiForm = new ThermansiForm();
                this.Hide();
                thermansiForm.Show();
            }
            else if (radioButton4.Checked)
            {
                KafetieraBrastirasForm form = new KafetieraBrastirasForm();
                this.Hide();
                form.Show();
            }
            else if (radioButton5.Checked)
            {
                TVForm form = new TVForm();
                this.Hide();
                form.Show();
            }
            else
            {
                ThermometroForm form = new ThermometroForm();
                this.Hide();
                form.Show();
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Gray;
            radioButton2.ForeColor = Color.Black;
            radioButton4.ForeColor = Color.Gray;
            radioButton5.ForeColor = Color.Gray;
            radioButton6.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arxiki form = new Arxiki();
            this.Hide();
            form.Show();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "37");
        }

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }

        private void EpilogesSyskeuesSpitiou_Load(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Gray;
            radioButton4.ForeColor = Color.Gray;
            radioButton5.ForeColor = Color.Gray;
            radioButton6.ForeColor = Color.Gray;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Gray;
            radioButton4.ForeColor = Color.Gray;
            radioButton5.ForeColor = Color.Gray;
            radioButton6.ForeColor = Color.Gray;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Gray;
            radioButton2.ForeColor = Color.Gray;
            radioButton4.ForeColor = Color.Black;
            radioButton5.ForeColor = Color.Gray;
            radioButton6.ForeColor = Color.Gray;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Gray;
            radioButton2.ForeColor = Color.Gray;
            radioButton4.ForeColor = Color.Gray;
            radioButton5.ForeColor = Color.Black;
            radioButton6.ForeColor = Color.Gray;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Gray;
            radioButton2.ForeColor = Color.Gray;
            radioButton4.ForeColor = Color.Gray;
            radioButton5.ForeColor = Color.Gray;
            radioButton6.ForeColor = Color.Black;
        }
    }
}
