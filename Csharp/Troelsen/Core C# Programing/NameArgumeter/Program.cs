using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameArgumeter
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayFancyMessage(textColor:ConsoleColor.DarkRed, message:"New text", backgroundColor:ConsoleColor.Magenta);

            Console.WriteLine("Named arguments. Step 2");

            DisplayFancyMessage(message: "Step 2", textColor: ConsoleColor.Yellow, backgroundColor: ConsoleColor.DarkRed);

        }

        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {   // Store old colors to restore after message is printed.    
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;

            // Set new colors and print message.   
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor; 

            Console.WriteLine(message);

            // Restore previous colors.    
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor; } 
        }
    }
