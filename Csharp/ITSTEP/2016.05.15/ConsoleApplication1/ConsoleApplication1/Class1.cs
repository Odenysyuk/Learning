using System;

namespace CA2
{
    class ForRefType
    {
        static public bool EnterNumber(out int number, string word)
        {

            Console.Write("\n \n Enter your {0} number:", word);
            string temp = Console.ReadLine();

            Boolean res = Int32.TryParse(temp, out number);
            if (!res)
            {
                Console.Write("Not correct choise!!!");
                number = 0;
                return res;
            }

            return res;


        }

        static public void CreateMenu()
        {
            Console.WriteLine("\tMENU:");
            Console.WriteLine("1. Enter first number;");
            Console.WriteLine("2. Enter second number;");
            Console.WriteLine("3. Adding;");
            Console.WriteLine("4. Subtracting;");
            Console.WriteLine("5. Multiplicating;");
            Console.WriteLine("6. Divising;");
            Console.WriteLine("7. Result;");
            Console.WriteLine("8. Exit;");

        }

        static public void DoResult(Int32 f, Int32 s, Int32 o)
        {
            switch (o)
            {
                case '+':
                    Console.Write("Res addiing is {0}", (double)(f + s));
                    break;
                case '-':
                    Console.Write("Res subtracting is {0}", (double)(f - s));
                    break;
                case '*':
                    Console.Write("Res multiplicating is {0}", (double)(f * s));
                    break;
                case '/':
                    if (s != 0)
                        Console.Write("Res divising is {0}", (double)(f / s));

                    break;
                default:
                    Console.Write("Not correct operation!!!");
                    o = ' ';
                    break;

            }
        }

        static void Main()
        {
            Int32 N = 15;
            Int32 first = 0, second = 0, choice = 0;
            Char @operator = ' ';

            do
            {
                Console.WriteLine("\n {0}. Referense. First number = {1}, second number = {2}, operator = {3}", N, first, second, @operator);

                CreateMenu();

                Console.Write("\n \n Enter your choice:");

                string ch = Console.ReadLine();
                Boolean result = Int32.TryParse(ch, out choice);

                if (!result)
                {
                    Console.Clear();
                    Console.Write("Not correct choise!!!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        EnterNumber(out first, "first");
                        break;
                    case 2:
                        EnterNumber(out second, "second");
                        break;
                    case 3:
                        @operator = '+';
                        break;
                    case 4:
                        @operator = '-';
                        break;
                    case 5:
                        @operator = '*';
                        break;
                    case 6:
                        @operator = '/';
                        break;
                    case 7:
                        DoResult(first, second, @operator);
                        N--;
                        break;
                    case 8:
                        N = 0;
                        break;
                    default:
                        Console.Write("Not correct choise!!!");
                        break;
                }

            } while (N != 0);



        }


    }
}
