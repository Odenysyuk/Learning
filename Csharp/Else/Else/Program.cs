using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void main()
    {
        int i;
        try
        {
            i = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine(" Uncorrect data");
            i = 0;

        }
        Console.WriteLine(" i = " + i);

        if (i == 1 || i == 2 || i == 3 || i == 5 || i == 7)
            Console.WriteLine(" Simple numbers!!!");
        else if (i % 2 == 0)
            Console.WriteLine(" Divided to 2");
        else if (i % 3 == 0)
            Console.WriteLine(" Divided to 3");
        else if (i % 5 == 0)
            Console.WriteLine(" Divided to 5");
        else if (i % 7 == 0)
            Console.WriteLine(" Divided to 7");
        else
            Console.WriteLine(" Simple numbers!!!");


    }

    static void Main1()
    {
        byte a, b, c;
        a = 10;
        b = 5;
       // c =  (a > b) ? a : b;
        Console.WriteLine(" Mas numbers is "+((a > b) ? a : b));

    }

    static void Main()
    {
        byte choise = 0;

        Console.WriteLine("Enter your choise:");
        try
        {
            choise = byte.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Not correct data");
        }
        

        switch (choise)
        {
            case 0:
                Console.WriteLine("Monday");
                break;
            case 1:
                Console.WriteLine("Tuesday");
                break;
            case 2:
                Console.WriteLine("Wedsneday");
                break;
            case 3:
                Console.WriteLine("Thursday");
                break;
            case 4:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("Weekand");
                break;
        }

 

    }


}
