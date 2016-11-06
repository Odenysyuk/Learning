using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Point p;
        Int32 Counter;
        Int32 CounterLeft;
        Timer T = new Timer();
        public Form1()
        {
            InitializeComponent();
            T.Tick += new EventHandler(TimerEventProcessor);
            T.Interval = 1000;
            T.Start();

        }



        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            p.X = e.X;
            p.Y = e.Y;

            Coordinate.Text = p.ToString();

        }


        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ++Counter;
                MessageBox.Show(Counter.ToString(), "Numbers of click", MessageBoxButtons.OK);
            }
            else
            {
                ++CounterLeft;
                BackColor = Color.Green;
            }
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            T.Stop();
            MessageBox.Show(String.Format("Left click - {0} \n Rigtn click - {1}", Counter.ToString(), CounterLeft.ToString()), "Numbers of click", MessageBoxButtons.OK);
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            T.Start();
        }


    }
}
