﻿using System;
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
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPAddress ip = IPAddress.Loopback;
            IPEndPoint point = new IPEndPoint(ip, 1024);

            try
            {
                socket.Connect(point);
                if(socket.Connected)
                {
                    String str = String.Format("&login{0}&password{1}", login.Text, password.Text);
                    byte[] data = Encoding.ASCII.GetBytes(str);
                    SocketError error;
                    socket.BeginSend(data, 0, data.Length, SocketFlags.None, out error, OnSend, socket);
                    //socket.Send(data);                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }


        }

        static void OnSend(IAsyncResult res)
        {
            String str = "";
            (res.AsyncState as Socket).EndSend(res);

            byte[] answer = new byte[1024];
            int l = (res.AsyncState as Socket).Receive(answer);
            if (l > 0)
            {
                str = Encoding.ASCII.GetString(answer, 0, l);
                if (str.Contains("-1"))
                {
                    MessageBox.Show("Error. Not correct data!!!");
                }
                else
                    MessageBox.Show(str.Replace("&", " "), "Users", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }

            (res.AsyncState as Socket).Close();
        }
    }
}
