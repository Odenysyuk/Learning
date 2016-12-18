using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForeachLoop();
            WhileLoopExample();
        }

        static void ForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I = {0:d}", i);
            }
        }

        static void ForeachLoop()
        {
            string[] array = {"One", "Two", "Three" };
            foreach(string el in array)
            {
                Console.WriteLine("El is {0}", el);
            }
        }

        static void WhileLoopExample()
        {
            string userIsDone = "";

            // Test on a lower-class copy of the string.  
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");     
                userIsDone = Console.ReadLine();
            }
        } 

        static void SwitchExample()
        {
            Console.WriteLine("1 [Apple] 2 [Banana]");
            Console.WriteLine("Please, pick fruit");
            string lChoice = Console.ReadLine();
            int n = int.Parse(lChoice);

            switch (n)
            {
                case 1: Console.WriteLine("Yuor choise is apple");
                    break;
                case 2: Console.WriteLine("Yous choise is banana");
                    break;
                default:
                    Console.WriteLine("Uncorrect choisen");
                    break;

            } 
        }
        }
    }
