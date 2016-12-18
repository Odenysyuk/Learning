using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x; Y = y;
        }

        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("[{0},{1}]", X, Y);
        }
    }
    public class PoinRef
    {
        int X;
        int Y;
        public PoinRef(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("[{0},{1}]", X, Y);
        }
    }

    public class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info)
        {
            this.infoString = info;
        }
    }
    struct Rectangle
    {      
        public ShapeInfo rectInfo; 

        public int rectTop, rectLeft, rectBottom, rectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectBottom = bottom;
            rectLeft = left;
            rectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " + "Left = {3}, Right = {4}", 
                rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeAssignment();
            ReferenceTypeAssignment();
            ValueTypeContainingRefType();
        }

        static void ValueTypeAssignment()
        {
            Console.WriteLine("=> Assinning value type");

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            p1.Display();
            p2.Display();

            p1.Increment();
            Console.WriteLine("p1.Increment()");
            p1.Display();
            p2.Display();


        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference type:");
            PoinRef p1 = new PoinRef(10, 10);
            PoinRef p2 = p1;

            p1.Display();
            p2.Display();

            p1.Increment();
            Console.WriteLine("p1.Increment()");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            Console.WriteLine("=>Creating r1");

            Rectangle r1 = new Rectangle("First rect", 10, 10, 50, 50);

            Console.WriteLine("Assinning r2 to r1");
            Rectangle r2 = r1;

            Console.WriteLine("Changing r2");
            r2.rectInfo.infoString = "Second rect";
            r2.rectTop = 12;

            r1.Display();
            r2.Display();
        }

    }
}
