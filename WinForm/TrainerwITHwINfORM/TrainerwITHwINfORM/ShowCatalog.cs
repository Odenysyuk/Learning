using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainerwITHwINfORM
{
    public partial class ShowCatalog : Form
    {
        string NameFile
        {
            get { return nameFile; }
            set
            {
                tPath.Text = value;
                nameFile = value;
            }
        }
        string nameFile;
        public ShowCatalog()
        {
            InitializeComponent();
        }

        private void bOpenFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                NameFile = file.FileName;
                using (file.OpenFile())
                {

                }
            }
        }
    }
}
