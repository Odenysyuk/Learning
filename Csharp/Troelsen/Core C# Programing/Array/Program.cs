using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleArray();
            ImplicityTypeArray();
            ArrayOfObjects();
            RectangularMultidimensionalArray();
            JaggedMultidimensionalArray();
            BaseOperationWithArray();

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

            PrintStringArray(GetArrayOfString());
        }

        static void ImplicityTypeArray()
        {
            Console.WriteLine("=>Implicity typed array");
            var a = new[] { 1, 2, 3, 4, 5 };//int[]
            Console.WriteLine("a is {0}", a.ToString());
            PrintArray(a);

            var b = new[] { 1, 2, 3.0, 4, 5 };//double[]
            Console.WriteLine("b is {0}", b.ToString());

            var mix = new[] { (object)1, (object)"hello", (object)1.3 };
            Console.WriteLine("mix is {0}", mix.ToString());
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of object:");

            object[] array = new object[5]{ 1, 2.5, "Hello", false, 'a' };
            int i = 0;
            foreach (object item in array)
            {
                Console.WriteLine("array[{0}] = {1}, type is {2}", i++, item, item.GetType());
            }


        }

        static void RectangularMultidimensionalArray()
        {
            Console.WriteLine("=> REctangular multidimensional arrays:");
            int[,] matrix = new int[3, 3];
            for (int i = 0; i< 3; i++)
            {
                for (int j= 0; j < 3; j++)
                {
                    matrix[i, j] = i * j;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array");

            int[][] array = new int[5][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[i + 7];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0} ", array[i][j]);
                }
                Console.WriteLine();
            }
        }

        static void PrintArray(int[] myInts)
        {
            foreach(int item in myInts)
                Console.Write(" {0} ", item);
            Console.WriteLine();
        }

        static String[] GetArrayOfString()
        {
            string[] temp = new string[] {"Hello", " ", "My name", "is ", "Olena" };
            return temp;
        }

        static void PrintStringArray(String[] myStrings)
        {
            Console.WriteLine("=> Print array of myStrings");
            foreach (string item in myStrings)
                Console.Write(" {0} ", item);

            Console.WriteLine();

        }

        static void BaseOperationWithArray()
        {
            Console.WriteLine();
            Console.WriteLine("=> Member of ARRAY CLASS");

            int[] temp = new int[] { 2, 5, 6, 8, 7, 1 };
            PrintArray(temp);

            Array.Reverse(temp);
            Console.WriteLine("After reverce:");
            PrintArray(temp);

            Array.Clear(temp, 2, 1);
            Console.WriteLine("After Array.Clear(temp, 2, 1):");
            PrintArray(temp);

            Console.WriteLine(" temp.CopyTo(temp2, 0) print:");
            int[] temp2 = new int[6];
            temp.CopyTo(temp2, 0);
            PrintArray(temp2);

            Console.WriteLine("Rank of temp {0}", temp.Rank);

            Array.Sort(temp);
            Console.WriteLine("Sort array:");
            PrintArray(temp);


        }
    }
}
