using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _UdpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient("localhost", 1024);
            IPEndPoint ep = null;// new IPEndPoint(IPAddress.Loopback, 1024);
            //while (true)
            //{
                byte[] data = client.Receive(ref ep);
                Console.WriteLine("Data: \"{0}\" from client: {1}", Encoding.ASCII.GetString(data), ep.Address);
              //  data = Encoding.ASCII.GetBytes("Server answer");
               // client.Send(data, data.Length, ep);
            //}
      
        }
    }
}
