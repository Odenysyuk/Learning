using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Russy", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);

            foreach(Car el in myAutos)
            {
                el.PrintState();
            }

            Array.Sort(myAutos, Car.SortByPetName);
            Console.WriteLine();

            foreach (Car el in myAutos)
            {
                el.PrintState();
            }

            Console.ReadLine();
        }
    }
}
