using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ComparableCar
{
    public class Car:IComparable
    {
        public int currSpeed;
        public string petName;

        public int CarId { get; set; }

        public static IComparer SortByPetName { get { return (IComparer)new PetNameCompare(); } }

        public void SpeedUp(int delta)
        {
            this.currSpeed += delta;

        }
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH, id = {2}", petName, currSpeed, CarId);
        }

        public int CompareTo(object obj)
        {
            Car temp = obj as Car;
            if(temp != null)
            {
                if (this.CarId > temp.CarId)
                    return 1;
                if (this.CarId < temp.CarId)
                    return -1;

                return 0;
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
           
        }

        public Car()
        {
            this.currSpeed = 15;
            this.petName = "Chuck";
        }

        public Car(string petName, int currSpeed)
        {
            this.currSpeed = currSpeed;
            this.petName = petName;

        }

        public Car(string petName, int currSpeed, int id)
        {
            this.currSpeed = currSpeed;
            this.petName = petName;
            this.CarId = id;

        }

    }
}
