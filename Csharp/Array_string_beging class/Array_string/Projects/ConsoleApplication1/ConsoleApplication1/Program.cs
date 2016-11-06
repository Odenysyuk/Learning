using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Show(String[,] temp)
        {
            for (Int32 i = 0; i < temp.GetLength(0); i++)
            {
                for (Int32 j = 0; j < temp.GetLength(1); j++)
                {
                    Console.Write("{0} ", temp[i, j]);
                }
                Console.WriteLine();
            }
        }

        static String Authentication(String[,] temp, String name)
        {
            for (Int32 i = 0; i < temp.GetLength(0); i++)
            {
                if (temp[i, 0] == name)
                    return temp[i, 1];
            }
            return null;
        }

        static void CreateMenu() {
            Console.WriteLine("*************************");
            Console.WriteLine("\t\t Menu:");
            Console.WriteLine("1. Add new user; (enter - 1)");
            Console.WriteLine("2. Show all users; (enter - 2)");
            Console.WriteLine("3. Delete user; (enter - 3)");
            Console.WriteLine("4. Exitr; (enter - 0)");
            Console.WriteLine("*************************");
        }

        static String[,] AddNewUsers(String[,] data) {

            authentication:  Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();

            String parolData = Authentication(data, name);

            if (!String.IsNullOrEmpty(parolData))
            {
                Console.WriteLine("This user is already in the database");
                goto authentication;
            }

            Console.WriteLine("Enter your parol:");
            String parol = Console.ReadLine();


            String [,]temp = new String[data.GetLength(0) + 1, 2];
            for (int i = 0; i < data.GetLength(0); i++) {
                temp[i, 0] = data[i, 0];
                temp[i, 1] = data[i, 1];
            }

            temp[data.GetLength(0), 0] = name;
            temp[data.GetLength(0), 1] = parol;

            return temp;

        }

        static void DeleteUsers(out String[,] data)
        {
            data = new String[,] { { "admin", "0000" } };

        }
        

        static void Main(string[] args)
        {
            String[,] data = new String[,] { { "admin", "0000" } };

            authentication:
            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();

            String parolData = Authentication(data, name);

            if (String.IsNullOrEmpty(parolData))
            {
                Console.WriteLine("Cannot Connect to DATA");
                goto authentication;
            }


            Console.WriteLine("Enter your parol:");
            String parol = Console.ReadLine();

            if (String.IsNullOrEmpty(parol)
                || !parol.Equals(parolData))
            {
                Console.WriteLine("Incorrect parol");
                goto authentication;
              }
            else
            {
                Console.WriteLine("Successfully connect");
                Show(data);
            }


            do
            {
                CreateMenu();

                Int32 choise = 0;

                Boolean res = Int32.TryParse(Console.ReadLine(),out choise);
                if (!res)
                {
                    Console.WriteLine("Do not converted  to Int32");
                    continue;
                }


                switch (choise)
                {
                    case 0: return; 

                    case 1:
                        data = AddNewUsers(data);
                        break;
                    case 2:
                        Show(data);
                        break;
                    case 3:
                        DeleteUsers(out data);
                        break;

                    default:
                        Console.WriteLine("Do not correct data!");
                        continue; 
                }





            } while (true);

        }

    }
}