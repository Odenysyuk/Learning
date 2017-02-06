using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
        Thread calcThread;
        UdpClient client = new UdpClient(1024);
        public MainWindow()
        {
            InitializeComponent();
            calcThread = new Thread(ConnectionForChat);
            calcThread.IsBackground = true;
            calcThread.Start();
            this.Closed += CloseForm;
            
        }
  
        public void ConnectionForChat()
        {

            IPEndPoint ep = null;
            while (true)
            {
                byte[] data = client.Receive(ref ep);
                if (data == null || data.Length == 0)
                    return;
                String Text = Encoding.ASCII.GetString(data);


                this.Users.Dispatcher.Invoke(new Action(delegate()
                {
                    Users.Text += Text + Environment.NewLine;
        
                })); 
            }   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes("Lena: " + Msg.Text);

            for (int i = 1; i < 255; i++)
            {
                try
                {
                    IPEndPoint ep = new IPEndPoint(IPAddress.Parse(String.Format("10.7.31.{0}", i)), 1024);
                    client.Send(data, data.Length, ep);  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                   
                }
                
            }

            Msg.Text = "";
        }

        private void CloseForm(object sender, System.EventArgs e)
        {
            
            client.Close(); 
        }
    
    }

}
