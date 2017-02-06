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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Work_wirh_clien.xaml
    /// </summary>
    public partial class Work_wirh_clien : Window
    {
        WebClient client;
        string paramaters;
        string site = "http://10.7.26.8/";

        public Work_wirh_clien(WebClient cl, string param, string deposity)
        {
            InitializeComponent();
            client = cl;
            paramaters = param;
            deposit.Content = deposity;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string parameters = string.Format("{0}&getmoney={1}", paramaters, Money.Text);
            string answer = "";
            try
            {
                answer = client.DownloadString(site + parameters);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            int start = answer.IndexOf("Error");
            int finish;
            if (start > 0)
            {
                finish = answer.IndexOf("\n", start);
                Msg.Content = answer.Substring(start, finish - start);
                return;
            }

            start = answer.IndexOf("$");
            finish = answer.IndexOf("\n", start);
            if (start > 0 && finish > 0 && start != finish)
            {
                deposit.Content = answer.Substring(start, finish - start);
               
            }
            Money.Text = "";
        }
    }
}
