using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomInterface
{
    class Hexagon : Shape, IPoint, IDraw3D
    {
        public Hexagon(){}
        public Hexagon(string name):base(name){}

        public byte Points
        {
            get
            {
                return 6;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D!");
        }
    }
}
