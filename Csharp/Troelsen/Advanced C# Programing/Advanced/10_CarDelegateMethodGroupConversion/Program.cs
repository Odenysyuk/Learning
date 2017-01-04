using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CarDelegateMethodGroupConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Method group conversion **** \n*");

            Car c1 = new Car();
            c1.RegisterWithCarEngine(CallMeHere);
            c1.RegisterWithCarEngine(CallMeHereTwo);

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.UnRegisterWithCarEngine(CallMeHere);

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);


        }

        static void CallMeHere(string msg)
        {
            Console.WriteLine("=> Message from Car: {0}", msg);
        }

        static void CallMeHereTwo(string msg)
        {
            Console.WriteLine(" ******* {0}", msg);
        }



    }
}
