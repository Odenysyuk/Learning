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

namespace Task34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(new Contact("Test1", "04555646", "Adred ff ff"));
            listBox1.Items.Add(new Contact("Test2", "04555646", "Adred ff ff"));
        }
     
        class Contact
        {
            public String name { get; set; }
            public String numbers { get; set; }
            public String address { get; set; }
            public List<String> listEmails;
            public override string ToString()
            {
                return String.Format("{0}", name);
            }

            public Contact(String n = "default", String Numb = "0000", String addr = "default", String em = "www")
            {
                name = n;
                numbers = Numb;
                address = addr;
                listEmails = new List<string>();
                listEmails.Add(em);
            }

            public string ToParse()
            {
                String temp = "";
                foreach(var el in listEmails)
                {
                    temp = temp + " " + el;
                }
                return String.Format("{0} {1} {2} {3}", name, numbers, address, temp);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Contact temp =  listBox1.SelectedItem as Contact;
            textBox1.Text = temp.name;
            textBox2.Text = temp.numbers;
            textBox3.Text = temp.address;
            foreach(var el in  temp.listEmails)
            {
                comboBox1.Items.Add(el);
            }

        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Contact(textBox1.Text, textBox2.Text, textBox3.Text));

        }

        private void saveContact_Click(object sender, EventArgs e)
        {
            Soap
            using (FileStream f = new FileStream("base.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                f.Seek(0, SeekOrigin.Begin);
                Byte[] temp;
                foreach(var el in listBox1.Items)
           
                }
                await f.WriteAsync();
            };
            

        }
    }
}
