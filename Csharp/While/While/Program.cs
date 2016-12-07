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
            string aa, b;

            while (true)
            {
                aa = NewMethodToFirst();
                if (aa == "q")
                    break;

                Console.Write("Enter, second numbers:");
                b = Console.ReadLine();
                if (b == "q")
                    break;


                try
                {
                    Console.WriteLine(aa + " / " + b + " = " + float.Parse(aa) / float.Parse(b));
                }
                catch
                {
                    Console.WriteLine("b == 0");
                }

            }



        }

        private static string NewMethodToFirst()
        {
            string a;
            Console.Write("Enter, first numbers:");
            a = Console.ReadLine();
            return a;
        }
    }
}
