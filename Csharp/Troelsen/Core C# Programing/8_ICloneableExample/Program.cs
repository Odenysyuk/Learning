using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Interfaces *****\n");

            //All of these classes suport the ICloneable interface
            String myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());

            System.Data.SqlClient.SqlConnection sqlCnn =
                new System.Data.SqlClient.SqlConnection();

            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);
            Console.ReadLine();
        }

        private static void CloneMe(ICloneable c)
        {
            //Clone whatever we get and print out the name
            object theClone = c.Clone();

            Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
        }
    }
}
