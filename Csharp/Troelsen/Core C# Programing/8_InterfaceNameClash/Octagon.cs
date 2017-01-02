using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer.....");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory.....");
        }

        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form.....");
        }
    }
}
