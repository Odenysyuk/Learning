using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main()
        {
            string a, b;

            while (true)
            {
                Console.Write("Enter, first numbers:");
                a = Console.ReadLine();
                if (a == "q")
                    break;

                Console.Write("Enter, second numbers:");
                b = Console.ReadLine();
                if (b == "q")
                    break;


                try
                {
                    Console.WriteLine(a + " / " + b + " = " + float.Parse(a) / float.Parse(b));
                }
                catch
                {
                    Console.WriteLine("b == 0");
                }

            }



        }
    }
}
