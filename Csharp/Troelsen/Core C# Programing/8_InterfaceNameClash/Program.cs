using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {

            Octagon oct = new Octagon();           

            IDrawToForm itfForm = (IDrawToForm) oct;
            itfForm.Draw();

            ((IDrawToMemory)oct).Draw();

            if(oct is IDrawToPrinter)
            {
                (oct as IDrawToPrinter).Draw();
            }

            Console.Read();
        }
    }
}
