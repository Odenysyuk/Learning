using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerProgram
    {
        static List<string> logins;
        delegate void ConnecDelegate(Socket s);
        delegate void StartNetwork(Socket s);

        Socket socket;
        IPEndPoint point;

        public ServerProgram(IPAddress ip, int port)
        {
            point = new IPEndPoint(ip, port);

            logins = new List<string>()
            {
                "&Olena&1234",
                "&Temp&1234",
                "&Admin&1234",
                "&User&1234",
                "&Test&1234",

            };
        }

        public void Server_Connect(Socket s)
        {
            // Receiving data
            byte[] data = new byte[1024];
            int l = s.Receive(data);
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
            s.Send(Encoding.ASCII.GetBytes(str));

            s.Shutdown(SocketShutdown.Both);
            s.Close();

        }

        public void Start()
        {
            if (socket != null)
                return;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket.Bind(point);
            socket.Listen(10);
            StartNetwork start = new StartNetwork(Server_Begin);
            start.BeginInvoke(socket, null, null);
        }

        void Server_Begin(Socket s)
        {
            if (s == null)
                return;

            while (true)
            {
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Server listening...");
                        Socket remoteClient = socket.Accept();
                        ConnecDelegate cd = new ConnecDelegate(Server_Connect);
                        cd.BeginInvoke(remoteClient, null, null);                       
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void Stop()
        {
            if (socket == null)
                return;

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;

        }



    }
    class Program
    {
        
        static void Main(string[] args)
        {
            ServerProgram s = new ServerProgram(IPAddress.Loopback, 1024);
            s.Start();

            Console.ReadLine();
            s.Stop();
        }
    }
}
