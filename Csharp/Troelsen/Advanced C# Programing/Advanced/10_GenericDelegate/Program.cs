using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T arg);
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" = > Generic Delegate");
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Generic delegete type - > string");


            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(15);


        }

        static void StringTarget(string arg) { Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper()); }

        static void IntTarget(int arg) { Console.WriteLine("++arg is: {0}", ++arg); }
    }
}
