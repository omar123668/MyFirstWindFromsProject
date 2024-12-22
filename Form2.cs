using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstWindFromsProject.Properties;

namespace MyFirstWindFromsProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
          
            pictureBox1.Image = Image.FromFile(@"c:\BOy(2).jpg");
            lbTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
           
            pictureBox1.Image = Image.FromFile(@"c:\Girl.jpg");
           lbTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
          
            pictureBox1.Image = Image.FromFile(@"c:\Book.png");
            lbTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
          
            pictureBox1.Image = Image.FromFile(@"c:\Pen.jpg");
            lbTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

      
    }
}
