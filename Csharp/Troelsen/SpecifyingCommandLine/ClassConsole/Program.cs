using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(60, 5);
            Console.Beep();// beep for default

            //set bachgroundcolor for the current output
            Console.BackgroundColor = ConsoleColor.Blue;

            //set foreground colors for the current output
            Console.ForegroundColor = ConsoleColor.White;

            Console.BufferHeight = 50;
            Console.BufferWidth = 150;

            Console.Title = "Class console";
            Console.WriteLine("1 2 3 ");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("**********Basic Console i/O");
            GetUserData();
            OutputNumericalData();
        }

        static void GetUserData()
        {   // Get name and age.   
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change echo color, just for fun.   
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Echo to the console.   
            Console.WriteLine("Hello {0}!  You are {1} years old.",     userName, userAge);
            Console.WriteLine("Test");
            // Restore previous color.   
            Console.ForegroundColor = prevColor;
        } 

        static void OutputNumericalData()
        {
            Console.WriteLine("{0:c}", 15);//currency
            Console.WriteLine("{0:d}", 15);//decimal number
            Console.WriteLine("{0:e}", 99999999);//exponentical notation
            Console.WriteLine("{0:E}", 99999999);//exponentical notation
            Console.WriteLine("{0:F}", 9999.9999);//fixed-point formatiing
            Console.WriteLine("{0:G}", 9999.9999);//general formatiing


            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            // Notice that upper- or lowercasing for hex   
            // determines if letters are upper- or lowercase.   
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);   
            Console.WriteLine("x format: {0:x}", 99999);
        }


    }
  }
