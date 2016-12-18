using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            NewingDataTypes();
            ObjectFunctionality();
            UserDatesAndTimes();
            UseBigInteger();
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            // Set to false.   
            int i = new int();
            // Set to 0.   
            double d = new double();
            // Set to 0.   
            DateTime dt = new DateTime();     
            // Set to 1/1/0001 12:00:00 AM   
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");

            // A C# int is really a shorthand for System.Int32,   
            // which inherits the following members from System.Object.   
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine(); }

        static void ParseFromStrings()
    {
        Console.WriteLine("=> Data type parsing:");
        bool b = bool.Parse("True");
        Console.WriteLine("Value of b: {0}", b);
        double d = double.Parse("99.884");
        Console.WriteLine("Value of d: {0}", d);
        int i = int.Parse("8");
        Console.WriteLine("Value of i: {0}", i);
        char c = Char.Parse("w");
        Console.WriteLine("Value of c: {0}", c); Console.WriteLine();
    }

        static void UserDatesAndTimes()
        {
            Console.WriteLine("=> Dates nad Times:");

            //This constructor takes (year, month, day)
            DateTime dt = new DateTime(2017, 12, 31);
            Console.WriteLine("Date of {0} is {1}", dt.Date, dt.DayOfWeek);

            dt =  dt.AddMonths(2);
            Console.WriteLine("New date after adding 2 moths is {0}", dt.Date);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            // This constructor takes (hours, minutes, seconds).   
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts); 

            // Subtract 15 minutes from the current TimeSpan and  
            // print the result.   
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0))); 
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy = BigInteger.Parse("15555555555555555555555555555555555555555555555555555");
            Console.WriteLine("Big integer is {0}", biggy);
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, 
                        BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
        }
    }
}
