using System;
using System.Collections;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxUnboxOperation();
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;

            object boxedInt = myInt;

            int boxedVal = (int)boxedInt;
            try
            {
                long unboxedInt = (long)boxedInt;
            }  
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(30);

            int i = (int)myInts[0];

            Console.WriteLine("Value of your int: {0}", i);
        }
    }
}
