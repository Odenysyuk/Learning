using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");

            // First, make a Car object.  
            Car c1 = new Car("SlugBug", 100, 10);

            // Now, tell the car which method to call    
            // when it wants to send us messages.     
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent1);
            c1.RegisterWithCarEngine(handler2);

            // Speed up (this will trigger the events).   

            Console.WriteLine("***** Speeding up *****");     
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.UnRegisterWithCarEngine(handler2);
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }


        public static void OnCarEngineEvent(string msg)
        {   
            Console.WriteLine("\n***** Message From Car Object *****");   
            Console.WriteLine("=> {0}", msg);  
            Console.WriteLine("***********************************\n");  
        }

        public static void OnCarEngineEvent1(string msg)
        {

            Console.WriteLine("=> {0}", msg.ToUpper());

        }
    }
}
