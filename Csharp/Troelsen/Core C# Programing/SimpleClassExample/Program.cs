using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Fun with Class Types");

            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Car chuck = new Car();
            chuck.PrintState();

            Motorcycle mc = new Motorcycle(1);
            mc.PopAWheely();
   

        }
    }
}
