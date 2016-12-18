using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Car
    {
        public const int MaxSpeed = 100;

        // Car properties.   
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;
        private Radio theMusicBox = new Radio();

        // Constructors.   
        public Car() { }
        public Car(string name, int speed)
        { CurrentSpeed = speed; PetName = name; }

        public void CrankTunes(bool state)
        {     // Delegate request to inner object.   
            theMusicBox.TurnOn(state);
        }

        // See if Car has overheated.  
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");

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
                    CarIsDeadException ex = 
                        new CarIsDeadException(string.Format("{0} has overheated!", PetName), 
                                               "You have a lead foot", DateTime.Now);
                    ex.HelpLink = @"http://www.CarsRUs.com";

                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
