using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindFromsProject
{
    public partial class Form_Drawing : Form
    {
        public Form_Drawing()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);
            Pen Pen=new Pen(Black);
            
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 100, 20, 100, 100);


            e.Graphics.DrawRectangle(Pen, 200, 200, 100, 100);
            e.Graphics.DrawEllipse(Pen, 100, 10, 100, 120);

            
        }
    }
}
