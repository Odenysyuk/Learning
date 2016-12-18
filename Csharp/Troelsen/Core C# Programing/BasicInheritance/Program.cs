using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Basic Inheritance");

            //Car myCar = new Car(80) {Speed = 50};
            //Console.WriteLine("My car is going {0}MPH", myCar.Speed);

            //MiniVan myVan = new MiniVan() { Speed = 10 };
            //Console.WriteLine("My van is going {0}MPH", myVan.Speed);

            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson() { Age = 31, Name = "Fred", SalesNumber = 50 };
            fred.DisplayStats();

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();



        }
    }
}
