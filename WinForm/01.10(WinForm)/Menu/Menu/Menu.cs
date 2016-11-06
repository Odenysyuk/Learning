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

namespace Menu
{
    public partial class Menu : Form
    {

         
        public Menu()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream io;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt) | *.txt | All files(*.*) | *.*";
            ofd.FilterIndex = 2;
            DialogResult button = ofd.ShowDialog();
            if (button == DialogResult.OK)
            {
                try
                {
                    if ((io = ofd.OpenFile()) != null)
                    {
                        using (io)
                        {
                            io.Seek(0, SeekOrigin.Begin);
                            byte[] buffer = new Byte[io.Length];
                            if (io.CanRead && io.CanSeek)
                            {
                                io.Read(buffer, 0, (int)io.Length);
                            }

                            UTF8Encoding temp = new UTF8Encoding(true);
                            textBox1.Text += temp.GetString(buffer);
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            ofd.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream io;
            SaveFileDialog ofd = new SaveFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if ((io = ofd.OpenFile()) != null)
                {
                    StreamWriter sw = new System.IO.StreamWriter(io);
                    sw.WriteLine(textBox1.Text);
                    sw.Flush();
                    io.Close();
                }
            }

        }
        
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.Cut();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
            
        }


    }
}
