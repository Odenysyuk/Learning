using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_MIInterfaceHierarchy
{
    interface IDrawable {
        void Draw();
    }

    interface IPrintable
    {
        void Print();
        void Draw();

    } 

    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    } 

        class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
