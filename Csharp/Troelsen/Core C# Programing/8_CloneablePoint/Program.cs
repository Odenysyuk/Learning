using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ICloneable");
            
            Point p1 = new Point(50, 50);
            Point p2 = p1.Clone() as Point;

            Console.WriteLine("p1=p2 => {0}", p1.Equals(p2));

            Console.WriteLine("Before modofication:");

            Console.WriteLine(p1);
            Console.WriteLine(p2);    

            p2.X = 0;
            Console.WriteLine("After modofication:");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
