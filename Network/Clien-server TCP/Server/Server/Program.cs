using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static List<string> logins;
        static void Main(string[] args)
        {
            logins = new List<string>()
            {
                "&Olena&1234",
                "&Temp&1234",
                "&Admin&1234",
                "&User&1234",
                "&Test&1234",

            };
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPAddress ip = IPAddress.Loopback;
            IPEndPoint point = new IPEndPoint(ip, 1024);
            socket.Bind(point);
            socket.Listen(10);

            try
            {
                while (true)
                {
                    Console.WriteLine("Server listening...");
                    Socket remoteClient = socket.Accept();

                    // Receiving data
                    byte[] data = new byte[1024];
                    int l = remoteClient.Receive(data);
                    String str = Encoding.ASCII.GetString(data, 0, l);

                    str = str.Replace("login", "");
                    str = str.Replace("password", "");

                    if (String.IsNullOrEmpty(logins.Find(x => x.Equals(str))))
                        str = "-1";
                    else
                    {
                        String temp = "";
                        foreach (string el in logins)
                        {
                            temp += el + "\n";
                        }
                        str = temp;
                    }
                    Console.WriteLine("{0}", str);
                   
                    //Sending data
                    remoteClient.Send(Encoding.ASCII.GetBytes(str));

                    remoteClient.Shutdown(SocketShutdown.Both);
                    remoteClient.Close();
                }               
         

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);              
            }

        }
    }
}
