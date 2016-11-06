using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4
{
    public partial class Form1 : Form
    {
        public bool ActiveSetupAll = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Setup FormSetup = new Setup(this);
            FormSetup.ShowDialog();
        }

        private void AddAll_Click(object sender, EventArgs e)
        {
            if (!ActiveSetupAll)
            {
                SetupAll FormSetup = new SetupAll(this);
                FormSetup.Show();
                ActiveSetupAll = true;
            }
        }
    }
}
