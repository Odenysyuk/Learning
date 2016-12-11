using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructure
{
    struct Point
    {
        public int X;
        public int Y;

        public void Increment()
        {
            X++;
            Y++;
        }

        public  void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("[{0},{1}]", X, Y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Struct");

            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            Console.WriteLine("Increment point");
            myPoint.Increment();
            myPoint.Display();

            Console.WriteLine("Decrement point");
            myPoint.Decrement();
            myPoint.Display();
        }
    }
}
