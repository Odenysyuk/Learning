using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        Int32 x1;
        Int32 y1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void Form_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int x2 = e.X;
            int y2 = e.Y;
            int X = Math.Min(x1, x2);
            int Y = Math.Min(y1, y2);


            Label label = new Label();
            Random r = new Random();
            label.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            label.Location = new Point(X, Y);
            label.Size =  new System.Drawing.Size(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
            this.Controls.Add(label);


        }
    }
}
