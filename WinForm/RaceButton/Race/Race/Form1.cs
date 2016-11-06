using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {

        Thread but1;
        Thread but2;
        Thread but3;
        Random r;

        delegate void HelpToCall(object b);
        HelpToCall h;

        public Form1()
        {
            InitializeComponent();
            h = new HelpToCall(Movement);
            r = new Random();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            but1 = new Thread(new ParameterizedThreadStart(MoveBuuton));           
            but2 = new Thread(new ParameterizedThreadStart(MoveBuuton));    
            but3 = new Thread(new ParameterizedThreadStart(MoveBuuton));            

           // but1.IsBackground = but2.IsBackground = but3.IsBackground = true;
            but2.Start(second_btn);
            but1.Start(first_btn);           
            but3.Start(third_btn);

        }


        void MoveBuuton(Object b)
        {
            if(h != null)
            {
                Invoke(h, b);
            }
            
        }

        void Movement(Object b)
        {
            Button bb = b as Button;          
            if (bb == null) return;
            
            while (this.Size.Width > bb.Location.X + bb.Size.Width)
            {
                Point t = bb.Location;
                bb.Location = new Point(t.X += r.Next(0,15), t.Y);
                Thread.Sleep(10);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (but1 != null && but1.IsAlive == true)
            {
                but1.Resume();
                but2.Resume();
                but3.Resume();
            }
        }
    }
}
