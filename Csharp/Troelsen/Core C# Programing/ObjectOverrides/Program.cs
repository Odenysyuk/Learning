using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string fName, string lName, int personAge)
        { FirstName = fName; LastName = lName; Age = personAge; }
        public Person() { }

        public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirstName, LastName, Age);
            return myState;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;
                if (temp.FirstName == this.FirstName && temp.LastName == this.LastName && temp.Age == this.Age)
                { return true; }
                else
                {
                    return false;
                }
            }
          return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> System.Object");

            Person p1= new Person() {FirstName = "Smith", LastName = "Tom", Age = 15 };
            Console.WriteLine("ToString(): {0}", p1.ToString());
            Console.WriteLine("Equals(): {0}", p1.Equals(new Person()));
            Console.WriteLine("GetHashCode(): {0}", p1.GetHashCode());
            Console.WriteLine("GetType(): {0}", p1.GetType());

            Person p2 = p1;
            object o = p2;
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }
        }
    }
}
