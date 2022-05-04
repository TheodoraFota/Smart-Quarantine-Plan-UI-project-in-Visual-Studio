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
    public partial class DiadromiForm : Form
    {
       
       
        public DiadromiForm()
        {
            InitializeComponent();
   

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Gray;
            radioButton3.ForeColor = Color.Gray;
            radioButton2.ForeColor = Color.Black;
            User.super_market = radioButton2.Checked;

           

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Gray;
            radioButton1.ForeColor = Color.Gray;
            radioButton3.ForeColor = Color.Black;
            User.gym = radioButton3.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Gray;
            radioButton3.ForeColor = Color.Gray;
            radioButton1.ForeColor = Color.Black;
            User.work = radioButton1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Epilogi1 f = new Epilogi1();
            User.time = dateTimePicker1.Value;
            this.Hide();
            f.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        { }
        

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.ForeColor = Color.Gray;
            checkBox3.ForeColor = Color.Black;
            checkBox5.ForeColor = Color.Gray;
            checkBox4.ForeColor = Color.Black;
            checkBox1.ForeColor = Color.Black;
            User.metro = checkBox1.Checked;

            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.ForeColor = Color.Gray;
            checkBox3.ForeColor = Color.Black;
            checkBox5.ForeColor = Color.Gray;
            checkBox4.ForeColor = Color.Black;
            checkBox1.ForeColor = Color.Black;
            User.onfoot = checkBox4.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.ForeColor = Color.Gray;
            checkBox3.ForeColor = Color.Black;
            checkBox5.ForeColor = Color.Gray;
            checkBox4.ForeColor = Color.Black;
            checkBox1.ForeColor = Color.Black;
            User.bus= checkBox3.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.ForeColor = Color.Gray;
            checkBox3.ForeColor = Color.Gray;
            checkBox1.ForeColor = Color.Gray;
            checkBox4.ForeColor = Color.Gray;
            checkBox5.ForeColor = Color.Black;
            User.car = checkBox5.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.ForeColor = Color.Gray;
            checkBox3.ForeColor = Color.Gray;
            checkBox1.ForeColor = Color.Gray;
            checkBox4.ForeColor = Color.Gray;
            checkBox2.ForeColor = Color.Black;
            User.bycicle = checkBox2.Checked;
     
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arxiki form = new Arxiki();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void σχετικάΜεΤηνΕφαρμογήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή δημιουργήθηκε από τους Μιχάλης Πολιτάκης, Θεοδώρα Φώτα, Παρασκευή Τσακίρη");
        }
        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Ui.chm", HelpNavigator.TopicId, "4");
        }

        private void DiadromiForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

