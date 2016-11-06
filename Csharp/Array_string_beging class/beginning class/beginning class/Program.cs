using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning_class
{
    public class Pansioner
    {
        private String name;
        private String surname;
        private Int32 age;
        private Single salary;
        private Single bonus;
        private Int32 documentCode;
        static private Int32 numbers_document;
        private const Int32 MinSalary = 1500;

        public Pansioner()
        {
            name = "default";
            surname = "default";
            age = 0;
            salary = MinSalary;
            bonus = 0;
            documentCode = ++numbers_document;
        }

        public Pansioner(String name, String surname, Int32 age, Single salary, Single bonus = 0)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salary = salary;
            this.bonus = bonus;
            this.documentCode = ++numbers_document;
        }


       static  Pansioner()
        {
            numbers_document = 0;
        }

        public void SetSalary(Single s) {
            if (MinSalary < s)
                this.salary = s;
            else
                Console.WriteLine("Sallary is less minimall salary");
        }

        public void SetSalary(Single s, Single b)
        {
            if (MinSalary < s)
                this.salary = s;
            else
                Console.WriteLine("Sallary is less minimall salary");

            if (b > 0)
                this.bonus = b;
            else
                Console.WriteLine("Bonus is not correctly!");

        }

        public void output() {
            Console.WriteLine("\t Pansioner:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine("Bonus: {0}", bonus);
            Console.WriteLine("Number of document: {0}", documentCode);
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pansioner Temp1 = new Pansioner();
            Temp1.output();

            Pansioner Temp2 = new Pansioner("Galina", "Smith", 50, 5000, 163);
            Temp2.output();
            Temp2.SetSalary(100);
            Temp2.SetSalary(10000, 50);
            Temp2.output();
        }
    }
}
