using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamda
{
    class Program
    {
        public delegate void lamdaMethod();
        public delegate int Sum(int a, int b);
        static void Main(string[] args)
        {

            lamdaMethod e = delegate { Console.WriteLine("My method"); };
            e();

            Sum calculate = delegate (int x, int y) { return x + y; };

            var sum_ = calculate(5, 3);
            Console.WriteLine(sum_);

            Func<int, int, int> sum2= delegate (int x, int y) { return x + y; };
            Console.WriteLine(sum2(5, 3));

            Func<int, int, int> dob = (x, y) => x * y;
            Console.WriteLine(dob(5, 3));

            //Func<int, Func<int, int, int>, int> some = (x, dob) => dob(2, 3) + x;

            Func<int, int> func1 = null;

            func1 = (x) => x == 0 ? 0 : func1(--x);

            Console.WriteLine(func1(15));

            func1 = (x) => {
                Console.WriteLine(x);
                return x == 0 ? 0 : func1(--x);
            };

            Console.WriteLine(func1(15));

            Action action = null;
            for(int cycle = 0; cycle < 5; cycle++)
            {
                action = () => Console.WriteLine(cycle);
                action();
            }

            Console.ReadLine();


        }

    }
}
