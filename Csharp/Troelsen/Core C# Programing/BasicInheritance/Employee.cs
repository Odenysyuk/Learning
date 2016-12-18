using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        public Employee() { }

        public Employee(string name, int id, float pay) : this(name, 0, id, pay, "") { }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            this.Name = name;
            this.ID = id;
            this.Pay = pay;
            this.Age = age;
            this.empSSN = ssn;
        }

        public int Age {
            get { return empAge; }
            set { empAge = value; }
        }

        public string GetName() { return Name; }
        public void SetName(string name)
        {
            if (name.Length > 15)
                Console.WriteLine("Error! Name must be less than 16 characters!");
            else this.Name = name;
        }

        public string Name {
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name must be less than 16 characters!");
                else empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public string SocialSecurityNumber { get { return empSSN; } }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}",  this.empName);
            Console.WriteLine("ID:{0}",     this.empID);
            Console.WriteLine("Pay: {0}",   this.currPay);
            Console.WriteLine("Age: {0}",   this.Age);
            Console.WriteLine("SocialSecurityNumber: {0}",   this.SocialSecurityNumber);
        }

        public class BenefitPackage
        {
            public enum BenefitPackageLevel { Standard, Gold, Platinum }

            public double ComputePayDeduction() { return 125.0; }
        }
    }
}
