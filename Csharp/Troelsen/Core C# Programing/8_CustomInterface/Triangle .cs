using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomInterface
{
    class Triangle: Shape, IPoint
    {

        public Triangle(){}
        public Triangle(string name): base(name:name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }

        public byte Points
        {
            get { return 3; }
           
        }
    }
}
