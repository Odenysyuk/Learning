using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndParameterModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 10;
            Console.WriteLine("x = {0} y = {1}", x , y);
            Console.WriteLine("Amount of numbers is {0}",AmountOfNumber(x, y));
            Console.WriteLine("x = {0} y = {1}", x, y);

            Console.WriteLine("Paramaeters out");
            int sum;
            AmountOfNumberOut(x, y, out sum);
            Console.WriteLine("Amount of numbers is {0}", sum);
            Console.WriteLine("x = {0} y = {1}", x, y);

            Console.WriteLine("Paramaeters ref");
            Console.WriteLine("Amount of numbers is {0}", AmountOfNumberRef(ref x, ref y));
            Console.WriteLine("x = {0} y = {1}", x, y);

            Console.WriteLine("Amount of 0, 1, 2, 3, 5, 15 is {0}", AmountOfNumberParam(1, 2, 3, 5, 15));


        }

        static int AmountOfNumber(int x, int y)
        {
            int ans =  x +y;

            x++;
            y += 150;

            return ans;
        }

        static void AmountOfNumberOut(int x, int y, out int ans)
        {
            ans = x + y;

            x++;
            y += 150;

        }

        static int AmountOfNumberRef(ref int x, ref int y)
        {
            int ans = x + y;

            x++;
            y += 150;

            return ans;
        }

        static int AmountOfNumberParam(params int[] values)
        {
            int ans = 0;

            foreach (int item in values)
            {
                ans += item;
            }

            return ans;
        }

        static int AmountOfNumberParam(params int values)
        {
            int ans = 0;

            foreach (int item in values)
            {
                ans += item;
            }

            return ans;
        }





    }
}
