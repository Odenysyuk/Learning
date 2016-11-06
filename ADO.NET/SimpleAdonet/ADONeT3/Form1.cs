using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONeT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable classes = DbProviderFactories.GetFactoryClasses();
            DbProviderFactory factory = DbProviderFactories.GetFactory(classes.Rows[3]);

            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = //""; sequrete data

            connection.Open();

            DbCommand command = connection.CreateCommand();

            command.CommandText = @"SELECT name, rent FROM property WHERE rent = (SELECT MAX(rent) FROM property);";

            DbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if(reader.Read())
                {
                    textBox1.Text =  reader[0].ToString() + ", " + reader[1].ToString();
                }
            }
            reader.Close();

            connection.Close();
        }
    }
}
