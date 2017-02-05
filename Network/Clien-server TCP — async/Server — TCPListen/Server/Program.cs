using System;
using System.Collections.Generic;
using System.IO;
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
        IPEndPoint  point = new IPEndPoint(IPAddress.Loopback, 1024);
        TcpListener tcpListener = new TcpListener(point);

            tcpListener.Start();

            while (true)
            {

                if (tcpListener.Pending())
                {
                    try
                    {
                        TcpClient tcpClient = tcpListener.AcceptTcpClient();
                        StreamReader sr = new StreamReader(tcpClient.GetStream(), Encoding.Unicode);

                        string str = sr.ReadLine();
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
                        NetworkStream ns = tcpClient.GetStream();
                        ns.WriteLine("{0}", str);

                        tcpClient.Close();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message); ;
                    }
                    


                }
            }
            


            //ServerProgram s = new ServerProgram(IPAddress.Loopback, 1024);
            //s.Start();

            //Console.ReadLine();
            //s.Stop();


        }
    }
}
