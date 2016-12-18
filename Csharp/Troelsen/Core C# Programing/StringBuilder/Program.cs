using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("Hello");
            StringBuilder str1 = new StringBuilder("Hello");
            Console.WriteLine("Equals between str and str1 {0}", str == str1);
            Console.WriteLine("Hello == Hello {0}", "Hello" == "Hello");

        }
    }
}
