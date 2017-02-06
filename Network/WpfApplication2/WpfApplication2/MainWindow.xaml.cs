using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WebClient client = new WebClient();
        string site = "http://10.7.26.8/";
  
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(login.Text) || String.IsNullOrEmpty(password.Text))
                return;
            string parameters = string.Format("?login={0}&password={1}", login.Text, password.Text);
            string answer = "";
            try
            {
                answer = client.DownloadString(site + parameters);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            int start = answer.IndexOf("$");
            int finish = answer.IndexOf("\n", start);
            if(start > 0 && finish>0 && start != finish)
            {
                string AmongDepposit = answer.Substring(start, finish - start);
                Work_wirh_clien win2 = new Work_wirh_clien(client, parameters, AmongDepposit);
                win2.Show();
                this.Close();
            }

        }
    }
}
