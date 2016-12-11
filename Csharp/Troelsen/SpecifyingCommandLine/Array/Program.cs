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
            ImplicityTypeArray();

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

            string[] array2 = { "red", "blue", "black", "pinck" };
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, array1[i]);
            }
        }

        static void ImplicityTypeArray()
        {
            var a = new[] { 1, 2, 3, 4, 5 };//int[]
            Console.WriteLine("a is {0}", a.ToString());

            var b = new[] { 1, 2, 3.0, 4, 5 };//double[]
            Console.WriteLine("b is {0}", b.ToString());

            var mix = new[] { (object)1, (object)"hello", (object)1.3 };
            Console.WriteLine("mix is {0}", mix.ToString());
        }

    }
}
