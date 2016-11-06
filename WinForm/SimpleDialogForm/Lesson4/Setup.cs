﻿using System;
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
    public partial class Setup : Form
    {
        Form1 parents;
        public Setup(Form1 parents)
        {
            InitializeComponent();
            this.parents = parents;
            textBox4.SelectedItem = textBox4.Items[0];
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Not filled form data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string res = String.Format("{0} {1} {2} {3}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            parents.listOfProduct.Items.Add(res);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
