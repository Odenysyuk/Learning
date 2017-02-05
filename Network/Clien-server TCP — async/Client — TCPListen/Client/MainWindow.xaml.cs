using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            IPEndPoint point = new IPEndPoint(IPAddress.Loopback, 1024);
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(point);
            try
            {
                
                NetworkStream nstream = tcpClient.GetStream();
                String str = String.Format("&login{0}&password{1}", login.Text, password.Text);
                byte[] data = Encoding.Unicode.GetBytes(str);
                nstream.Write(data, 0, data.Length);


                StreamReader sr = new StreamReader(tcpClient.GetStream(), Encoding.Unicode);
                string s = sr.ReadLine();
                if (s.Length > 0)
                {
                    MessageBox.Show(str.Replace("&", " "), "Users", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                tcpClient.Close();
            }


        }
    }
}
