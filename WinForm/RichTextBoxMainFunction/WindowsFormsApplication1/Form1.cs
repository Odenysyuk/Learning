using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.LoadFile("file.rtf");
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            for (int i = 0; i < installedFontCollection.Families.Length; ++i)
            {
                comboBox2.Items.Add(installedFontCollection.Families[i].Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.FromName(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromName(textBox2.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = (HorizontalAlignment)comboBox1.SelectedIndex;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox2.SelectedText, richTextBox1.SelectionFont.Size);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily.ToString(), (float)numericUpDown1.Value);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            richTextBox1.SaveFile("file.rtf");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            Font newFont = new Font(font.FontFamily.Name, font.Size, FontStyle.Bold);
            richTextBox1.SelectionFont = newFont;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            Font newFont = new Font(font.FontFamily.Name, font.Size, FontStyle.Italic);
            richTextBox1.SelectionFont = newFont;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            Font newFont = new Font(font.FontFamily.Name, font.Size, FontStyle.Underline);
            richTextBox1.SelectionFont = newFont;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = int.Parse(textBox3.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionRightIndent = int.Parse(textBox4.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = int.Parse(textBox5.Text);
        }
    }
}
