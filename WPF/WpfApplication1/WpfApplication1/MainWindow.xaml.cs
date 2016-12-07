using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Employers.Items.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String monthTemp = Month.SelectionBoxItem.ToString();
            
            Employers.Items.Add(new Employer { month = new DateTime(2016, Int32.Parse(monthTemp.Substring(monthTemp.IndexOf('#')+1)), 1), Salary = Int32.Parse(Salary.Text) });

        }

        public class Employer 
        {
            public DateTime month { get; set; }
            public String Month { get { return month.ToString("MMMM"); } set { Month = value;} }
            public Int32 Salary { get; set; }

            public Employer(){}

            public override string ToString()
            {
                return String.Format(" {0} {1} ", month.Month.ToString(), Salary.ToString()); ;
            }
        }

        private void Counter_Click_1(object sender, RoutedEventArgs e)
        {
            String var =  SelectMonth.Text;
            foreach (var el in Employers.Items)
            {
                var += " " + el.ToString();
            }

            Process proc = new Process();

            proc.StartInfo = new ProcessStartInfo("Foreign.exe", var);
            proc.Start();
            proc.WaitForExit();
            MessageBox.Show(proc.ExitCode.ToString());



        }



    }
}
