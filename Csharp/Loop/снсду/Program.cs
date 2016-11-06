using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  dowwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b  = 0;
            char operation = '\0';            
            do
            {
                
                try
                {
                    Console.WriteLine("Enter your first number:");
                    a = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your second  number:");
                    b = float.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("");
                    Console.WriteLine("+  add;");
                    Console.WriteLine("-  subtraction;");
                    Console.WriteLine("*  multiplication;");
                    Console.WriteLine("/  division;");
                    Console.WriteLine("q - exit");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    operation = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not correct date/ Try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }


                switch (operation)
                {
                    case '+':
                        Console.WriteLine("Your answer: " + (a + b));
                        break;
                    case '-':
                        Console.WriteLine("Your answer: " + (a - b));
                        break;
                    case '*':
                        Console.WriteLine("Your answer: " + (a * b));
                        break;
                    case '/':
                        if (b == 0)
                        {
                            Console.WriteLine("Bad data. Enter other date");
                            continue;
                        }
                        Console.WriteLine("Your answer: " + (a / b));
                        break;
                    case 'q':
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not coorect data;");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            while (operation != 'q') ;
        }
    }
}

namespace for1
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; Console.WriteLine(i++)) ;

        }
    }
}
