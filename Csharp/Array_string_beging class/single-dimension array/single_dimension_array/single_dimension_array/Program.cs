using System;
using System.Collections;
using System.Collections.Generic;

namespace single_dimension_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] ar = new Int32[10];

            // initialization array
            for (Int32 i = 0; i < 10; i++)
                ar[i] = i;
            ar[4] = -6;
            ar[5] = 0;

            //print array
            foreach (var i in ar)
                Console.WriteLine("{0} ", i);

            // The amount of positive elements of the array;
            Int32 amount = 0;


            foreach (Int32 i in ar)
                if(i > 0) amount = amount + i;

            Console.WriteLine("The amount of positive elements of the array: {0} ", amount.ToString());


            //2.The amount of negative elements in the array;
            amount = 0;
            foreach (Int32 i in ar)
                if (i < 0) amount = amount + i;

            Console.WriteLine("The amount of negative elements in the array: {0} ", amount.ToString());

            //3.The amount of array elements located between the first and last zero element of the array;
            amount = 0;
            Int32 index_begin = Array.FindIndex(ar, item => item == 0);
            Int32 index_last = Array.FindLastIndex(ar, item => item == 0);

            if (index_begin == -1)
            {
                Console.WriteLine("The amount of negative elements in the array: {0} ", 0.ToString());
            }
            else {
                for(Int32 i = index_begin; i < index_last; i++)
                    amount +=  i;

            }
            Console.WriteLine("The amount of array elements located between the first and last zero element of the array: {0} ", amount.ToString());

            //4.The product array elements with even numbers;
            amount = 1;
            foreach (Int32 i in ar)
                if (i%2 == 0 && i != 0) amount *= i;

            Console.WriteLine("The product array elements with even numbers: {0} ", amount.ToString());

            //5.The product array elements located between the first and the last negative element array;
            amount = 1;
            index_begin = Array.FindIndex(ar, item => item < 0);
            index_last = Array.FindLastIndex(ar, item => item < 0);

            if (index_begin == -1 || index_last == index_begin)
            {
                Console.WriteLine("The product array elements located between the first and the last negative element array: {0} ", 0.ToString());
            }
              else
            {                
                for (Int32 i = index_begin; i < index_last; i++)
                    amount *= i;
                Console.WriteLine("The product array elements located between the first and the last negative element array: {0} ", amount.ToString());
            }


            //6.The maximum element of the array;
            Array.Reverse(ar);
            Console.WriteLine("The maximum element of the array: {0} ", ar[0].ToString());


            //7.The minimum element of the array;
            Array.Sort(ar);
            Console.WriteLine("The minimum element of the array: {0} ", ar[0].ToString());


            //8.The number of zero elements;
            amount = 0;
            foreach (Int32 i in ar)
                if (i == 0) ++amount;

            Console.WriteLine("The number of zero elements: {0} ", amount.ToString());


            //9.The number of array elements that lie in the range;
            amount = 0;
            Array.Sort(ar);
            index_begin = Array.FindIndex(ar, item => item >= 3);
            index_last = Array.FindLastIndex(ar, item => item <= 5);

            if (index_begin == -1 )
            {
                Console.WriteLine("The number of array elements that lie in the range [3:5]: {0} ", 0.ToString());
            }
            else if (index_last == index_begin)
            {
                Console.WriteLine("The number of array elements that lie in the range [3:5]: {0} ", 1.ToString());
            }
            else
            {
                for (Int32 i = index_begin; i < index_last; i++)
                   ++amount;
                Console.WriteLine("The number of array elements that lie in the range [3:5]: {0} ", amount.ToString());
            }

            //10.The number of array elements equal;
            amount = 0;
            foreach (Int32 i in ar)
                if (i == 6) ++amount;

            Console.WriteLine("The number of array elements equal 6: {0} ", amount.ToString());



            //11.The amount of the array, placed to the last positive element;
            amount = 0;
            Array.Reverse(ar);
            foreach (Int32 i in ar)
                if (i > 0) amount += i;

            Console.WriteLine("The amount of the array, placed to the last positive element: {0} ", ar[0].ToString());



            for (Int32 i = 0; i < 10; i++)
                ar[i] = i;
            ar[4] = -6;
            ar[5] = 0;

            //print array
            foreach (var i in ar)
                Console.WriteLine("{0} ", i);
            


        }
    }
}
