using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            if (on) Console.WriteLine("Jamming...");
            else Console.WriteLine("Quiet time...");
        }
    }

    class Car
    {     
        public const int MaxSpeed = 100; 

        // Car properties.   
        public int CurrentSpeed {get; set;}
        public string PetName {get; set;}

        private bool carIsDead; 
        private Radio theMusicBox = new Radio(); 

        // Constructors.   
        public Car() {}
        public Car(string name, int speed)
        {     CurrentSpeed = speed;     PetName = name;   } 

        public void CrankTunes(bool state)
        {     // Delegate request to inner object.   
            theMusicBox.TurnOn(state);
        }

        // See if Car has overheated.  
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;        // carIsDead = true;
                    // Use the "throw" keyword to raise an exception.       
                    throw new Exception(string.Format("{0} has overheated!", PetName));
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    } 

        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {

                Console.WriteLine("\n*** Error!***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Massage: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);

            }
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();

        }
    }
}
