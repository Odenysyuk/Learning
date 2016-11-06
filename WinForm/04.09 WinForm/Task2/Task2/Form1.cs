using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void FormMouseDown(object sender, MouseEventArgs e)
        {
            Int32 x = e.X,  y = e.Y;
            Int32 w = Size.Width, h = Size.Height;


            if (e.Button == MouseButtons.Left)
            {
                if(x < (w - 20) && x > 20 
                    && y < (h - 20) && y > 20)
                    MessageBox.Show("Click is in the rectangle","", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Click isn't in the rectangle","", MessageBoxButtons.OK);


            }
            else
            {

                Text = String.Format(" {0} x {1}", w - 40 , h -40);
            }
        }
    }
}
