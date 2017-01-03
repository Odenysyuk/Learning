using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************");
            Console.WriteLine("Fun with list....");
            Console.WriteLine("***************");
            UseGenericSList();
            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Fun with stack....");
            Console.WriteLine("***************");
            UseGenericStack();
            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Fun with queue....");
            Console.WriteLine("***************");
            UseGenericQueue();

            Console.WriteLine("***************");
            Console.WriteLine("Fun with sorted set....");
            Console.WriteLine("***************");
            UseSortedSet();

        }

        static void UseGenericSList()
        {
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age = 48},
                new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person {FirstName = "Bart", LastName = "Simpson", Age = 5},
            };

            Console.WriteLine("Items in list: {0}",  people.Count);

            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Isert new item for list");
            people.Insert(2, new Person { FirstName = "Tom", Age = 8, LastName = "Smith" });

            Console.WriteLine("Items in list: {0}", people.Count);
            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }

            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
            }
        }

        static void UseGenericStack()
        {

            Stack<Person> people = new Stack<Person>();

            people.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 48 });
            people.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            people.Push(new Person { FirstName = "Bart", LastName = "Simpson", Age = 5 });


            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }

            try
            {
                Console.WriteLine("First people is {0}", people.Peek());
                Console.WriteLine("Popped off {0}", people.Pop());

                Console.WriteLine("First people is {0}", people.Peek());
                Console.WriteLine("Popped off {0}", people.Pop());

                Console.WriteLine("First people is {0}", people.Peek());
                Console.WriteLine("Popped off {0}", people.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }
            

        }

        static void UseGenericQueue()
        {

            Queue<Person> people = new Queue<Person>();
            people.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 48 });
            people.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            people.Enqueue(new Person { FirstName = "Bart", LastName = "Simpson", Age = 5 });

            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }

            // Peek at first person in Q.  
            Console.WriteLine("{0} is first in line!", people.Peek().FirstName);

            try
            {
                GetCoffee(people.Dequeue());
                GetCoffee(people.Dequeue());
                GetCoffee(people.Dequeue());
                GetCoffee(people.Dequeue());
            }
            catch (InvalidOperationException e)  
            {      Console.WriteLine("Error! {0}", e.Message);   }
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        static void UseSortedSet()
        {
            SortedSet<Person> people = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age = 48},
                new Person {FirstName = "Gat", LastName = "Simpson", Age = 25},
                new Person {FirstName = "Fer", LastName = "Simpson", Age = 99},
                new Person {FirstName = "Opp", LastName = "Simpson", Age = 1},
                new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person {FirstName = "Bart", LastName = "Simpson", Age = 5},
            };

            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }

            people.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }


        }

    }

}
