using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool myBool = null; errror, because Boolean isn't reference type
            Console.WriteLine();

            bool? myBool = null;
            Console.WriteLine("my Bool = {0}", myBool);

            Nullable<bool> nullableInt = null;
            Console.WriteLine("my Bool != null =>{0}", nullableInt.HasValue);
            Console.WriteLine("my Bool != null => {0}", nullableInt != null);

            Console.WriteLine("Operator ??");
            nullableInt = nullableInt ?? false;
            Console.WriteLine("my Bool = {0}", nullableInt);
            Console.WriteLine("my Bool != null => {0}", nullableInt != null);

            Console.WriteLine("Operator ??");
            nullableInt = nullableInt ?? true;
            Console.WriteLine("my Bool = {0}", nullableInt);
            Console.WriteLine("my Bool != null => {0}", nullableInt != null);




        }
    }
}
