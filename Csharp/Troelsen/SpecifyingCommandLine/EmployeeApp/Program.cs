using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            // Use the get/set methods to interact with the object's name.   
            emp.SetName("Marv");   
            Console.WriteLine("Employee is named: {0}",
                emp.GetName());
            Console.ReadLine(); 
        }
    }
}
