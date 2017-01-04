using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SimpleDelegate
{
    public delegate void BinaryOp(int x, int y);

    public class SimpleMath
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("****Simple Delegate Example*");

            SimpleMath s = new SimpleMath();
            BinaryOp b = new BinaryOp(s.Add);
            

            b(10, 10);

            b += s.Subtract;
            b(50, 25);
            DisplayDelegateInfo(b);
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate item in delObj.GetInvocationList())
            {
                Console.WriteLine("Method name is {0}", item.Method);
                Console.WriteLine("Type name is {0}", item.Target);
            }
        }
    }
}
