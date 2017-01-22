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
            UdpClient client = new UdpClient("localhost", 1023);
            IPEndPoint serverIp = new IPEndPoint(IPAddress.Broadcast, 1024);
            client.Connect(serverIp);
            byte[] msg = Encoding.ASCII.GetBytes("some msg ");
            client.Send(msg, msg.Length);
        }
    }
}
