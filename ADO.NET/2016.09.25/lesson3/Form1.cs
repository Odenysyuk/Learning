using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AnimalsApplication
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
            groupBox3.Visible = false;

            SoapFormatter formatter = new SoapFormatter();
            FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate, FileAccess.Read);
            Animal[] list = formatter.Deserialize(fs) as Animal[];
            foreach (Animal el in list)
            {
                ListOfAnimal.Items.Add(el);
            }
            fs.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Animal temp = null;

            if(RadChicken.Checked)
            {
                temp = new Chicken(
                           (radioMale.Checked)?Sex.male:Sex.female, 
                           Int32.Parse(ageOfAnimal.Text),
                           textBox1.Text, 
                           false
                           );
            }
            else if (RadDog.Checked)
            {
                temp = new Dog(
                           textBox5.Text,
                           (radioMale.Checked) ? Sex.male : Sex.female,
                           Int32.Parse(ageOfAnimal.Text),
                           textBox1.Text
                           );
            }
            else 
            {
                temp = new Fish(
                           (radioMale.Checked) ? Sex.male : Sex.female, 
                           Int32.Parse(ageOfAnimal.Text),
                           textBox1.Text, 
                           false
                           );

            }
            if (temp != null)
                ListOfAnimal.Items.Add(temp);

            MoveProgressBarr(toolStripProgressBar1);
        }

        private void Rad_CheckedChanged(object sender, EventArgs e)
        {
            if (RadChicken.Checked)
            {
                groupBox3.Visible = false;
            }
            else if (RadDog.Checked)
            {
                groupBox3.Visible = true; 
            }
            else
            {
                groupBox3.Visible = false;
            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (sender == null || e == null)
                return;

            if (ListOfAnimal.CheckedItems.Count == 0)
                return;

            for (int i = 0; i < ListOfAnimal.CheckedItems.Count; i++)
            {
                ListOfAnimal.Items.Remove(ListOfAnimal.CheckedItems[i]);
                i--;                
            }
            MoveProgressBarr(toolStripProgressBar1);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (ListOfAnimal.CheckedItems.Count == 0)
                return;

            Int32 age = 0;
            if (Int32.TryParse(ageOfAnimal.Text, out age) == false
                || textBox1.Text == "")
            {
                MessageBox.Show("Тot completed all field values", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i =0; i < ListOfAnimal.CheckedItems.Count; i++)
            {
                Animal el = ListOfAnimal.CheckedItems[i] as Animal;
                if (RadChicken.Checked)
                {
                    if (el is Chicken)
                    {
                        (el as Chicken).age = Int32.Parse(ageOfAnimal.Text);
                        (el as Chicken).sex = (radioMale.Checked) ? Sex.male : Sex.female;
                        (el as Chicken).breed = textBox1.Text;
                    }

                    continue;
                }
                else if (RadDog.Checked)
                {
                    if (el is Dog)
                    {
                        (el as Dog).age = Int32.Parse(ageOfAnimal.Text);
                        (el as Dog).sex = (radioMale.Checked) ? Sex.male : Sex.female;
                        (el as Dog).breed = textBox1.Text;
                        (el as Dog).alias = textBox5.Text;
                    }
                }
                else
                {
                    if (el is Fish)
                    {
                        (el as Fish).age = Int32.Parse(ageOfAnimal.Text);
                        (el as Fish).sex = (radioMale.Checked) ? Sex.male : Sex.female;
                        (el as Fish).breed = textBox1.Text;
                    }
                }
                ListOfAnimal.Items[ListOfAnimal.Items.IndexOf(el)] = el;      
            }
            MoveProgressBarr(toolStripProgressBar1);
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MoveProgressBarr(toolStripProgressBar1);
            SaveData();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveData();
        }

        

        private void SaveData()
        {
            Animal[] list = new Animal[ListOfAnimal.Items.Count];
            for (int i = 0; i < ListOfAnimal.Items.Count; i++)
            {
                list[i] = ListOfAnimal.Items[i] as Animal;
            }


            SoapFormatter formatter = new SoapFormatter();
            FileStream fs = new FileStream("data.dat", FileMode.Create, FileAccess.ReadWrite);
            formatter.Serialize(fs, list);
            fs.Close();
        }

        private void toEat_Click(object sender, EventArgs e)
        {
            if (numberOfFood.Value == 0)
                return;

            if (ListOfAnimal.CheckedItems.Count == 0)
                return;

            for (int i = 0; i < ListOfAnimal.CheckedItems.Count; i++)
            {
                Animal el = ListOfAnimal.CheckedItems[i] as Animal;
                el.ToEat((int)numberOfFood.Value);
                ListOfAnimal.Items[ListOfAnimal.Items.IndexOf(el)] = el;
            }

            MoveProgressBarr(progressBar1);

        }

        private void MoveProgressBarr(ToolStripProgressBar el)
        {
            el.Value = 0;
            el.Step = 5;
            el.Maximum = 100;
            while (el.Value != toolStripProgressBar1.Maximum)
            {
                el.Increment(toolStripProgressBar1.Step);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void MoveProgressBarr(ProgressBar el)
        {
            el.Value = 0;
            el.Step = 5;
            el.Maximum = 100;
            while (el.Value != toolStripProgressBar1.Maximum)
            {
                el.Increment(toolStripProgressBar1.Step);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
