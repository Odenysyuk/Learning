using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public Motorcycle(){
            Console.WriteLine("Constuctor by default");
        }

        public Motorcycle(int intensity):this(intensity, "") {
            Console.WriteLine("Constuctor with one parameter");
        }

        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("Constuctor with two parameters");
            if (intensity  > 10)
            {
                intensity = 10;
            }
            this.driverIntensity = intensity;
            this.driverName = name;
        }
        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeeee Haaaaaeewww!");
        }
    }
}
