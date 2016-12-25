using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomInterface
{
    abstract class Shape
    {
        public Shape(String name = "NoName")
        {
            PetName = name;
        }
        public string PetName { get; set; }
        public abstract void Draw();

    }
}
