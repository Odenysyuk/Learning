using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreign
{
    class Program
    {
        static Int32 Main(string[] args)
        {
            Int32 SelectMonth = Int32.Parse(args[1]);

            Int32 sum = 0;
            Int32 counter = 0;
            for (int i = 1; i < args.Length; i++) 
            {

                if (Int32.Parse(args[i]) <= SelectMonth)
                {
                    Console.WriteLine(counter);
                    sum += Int32.Parse(args[++i]);
                    ++counter;
                }
            }

            if (counter != 0) 
            {
                sum /= counter; 
            }
            
            return sum;

        }
    }
}
