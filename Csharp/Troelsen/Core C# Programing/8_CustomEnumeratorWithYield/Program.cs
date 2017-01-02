using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the Yield Keyword *****\n");

            Garage carLot = new Garage();

            // Get items using GetEnumerator().  
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.petName, c.currSpeed);
            } 

            Console.WriteLine();

            // Get items (in reverse!) using named iterator.  
            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH", c.petName, c.currSpeed);
            }

        Console.ReadLine(); 
        }
    }
}
