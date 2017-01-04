using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Action<> delegate, can have until 16 params");

            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget.Invoke("Action message!", ConsoleColor.Yellow, 5);

            Console.WriteLine();
            Console.WriteLine("Working with Func<>, this delegate retun value. Func is like Action, take up 16 arguments and custom retun value");

            Func<int, float, float> funcTarget = new Func<int, float, float>(Add);
            float res = funcTarget.Invoke(40, 5.5f);
            Console.WriteLine("40+ 5.5 = {0}", res);

            Func<int, float, string> funcTarget2 = new Func<int, float, string>(SumToString);
            string sum = funcTarget2(90, 300f);
            Console.WriteLine(sum);

        }
        static void DisplayMessage(string msg, ConsoleColor txtColor,  int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = previous;
           
        }

        static float Add(int x, float y)
        {
            return x + y;
        }

        static string SumToString(int x, float y)
        {
            return (x + y).ToString();
        }
    }
}
