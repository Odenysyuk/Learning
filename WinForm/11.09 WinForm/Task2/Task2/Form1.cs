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
            monthCalendar1.MinDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show((monthCalendar1.SelectionStart - DateTime.Today).Days.ToString());
        }
    }
}
