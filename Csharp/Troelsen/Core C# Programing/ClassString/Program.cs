using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassString
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = "This is string";
            Console.WriteLine("Lenght {0}", line.Length);
            Console.WriteLine("Compare string {0}", line.CompareTo("string"));
            BasicStringFunctionality();
            StringEquality();


        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        static void StringEquality()
        {
            Console.WriteLine("=> String equality:"); string s1 = "Hello!"; string s2 = "Yo!"; Console.WriteLine("s1 = {0}", s1); Console.WriteLine("s2 = {0}", s2); Console.WriteLine();
            // Test these strings for equality.   
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }
    }


}


   
