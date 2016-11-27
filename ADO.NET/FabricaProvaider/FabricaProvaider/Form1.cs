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

namespace FabricaProvaider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectionToDataBase( )
        {
            DataTable classes = DbProviderFactories.GetFactoryClasses();
            DbProviderFactory factory = DbProviderFactories.GetFactory(classes.Rows[1]);

            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=my.mdb";

            connection.Open();

            DbCommand command = connection.CreateCommand();

            command.CommandText = @"SELECT * FROM property;";

            DbDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; ++i)
            {
                Console.Write(reader.GetName(i) + "\t");
            }
            Console.WriteLine();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; ++i)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();

                }
            }
            reader.Close();

            connection.Close();


        }
    }
}
