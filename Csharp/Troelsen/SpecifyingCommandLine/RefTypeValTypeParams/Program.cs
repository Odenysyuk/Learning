using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;

        // Constructors.   
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person(){} 

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();

            SendAPersonByValue(ref fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();
            Console.ReadLine();
        }

        static void SendAPersonByValue(ref Person p)
        {  // Change the age of "p"?   
            p.personAge = 99;

            // Will the caller see this reassignment?   
            p = new Person("Nikki", 99);
            p.personAge = 199;
        } 

    }

    }

    
