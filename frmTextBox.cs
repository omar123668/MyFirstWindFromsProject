using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstWindFromsProject.Properties;

namespace MyFirstWindFromsProject
{
    public partial class frmTextBox : Form
    {
        public frmTextBox()
        {
            InitializeComponent();
        }

        private void frmTextBox_Load(object sender, EventArgs e)
        {
            RightToLeft = RightToLeft.Inherit;
           if( radioButton1.RightToLeft==RightToLeft||textBox5.RightToLeft==RightToLeft)
            {

                RightToLeft = RightToLeft.No;
                textBox5.Focus();
          
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.goding;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.goding;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Smart_a_Person;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"c:\programming.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
        }
    }
}
