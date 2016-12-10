using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleArray();

        }

        static void SimpleArray()
        {
            Console.WriteLine("=> Simple array:");

            int[] array = new int[3];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine("a[{0}] = {0}", i); 
            }

            string[] array1 = new string[]{"red", "blue", "black", "pinck" };
            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, array1[i]); 
            }
         }


    }
}
