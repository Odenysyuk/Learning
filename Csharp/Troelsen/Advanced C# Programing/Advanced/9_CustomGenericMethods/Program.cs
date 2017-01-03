using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CustomGenericMethods
{
    struct Point<T> where T : struct
    {
        T X { get; set; }
        T Y { get; set; }


        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }

        public void ResetPoint()
        {
            X = Y = default(T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p = new Point<int>(10, 10);

            Point<double> d = new Point<double>(10.5, 10.5);

        }
    }
}
