using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Interface\n");

            //Call Points property defined by IPointy
            Hexagon hex = new Hexagon();
            Console.WriteLine("Pint : {0}", hex.Points);

            Circle c = new Circle("Lisa");
            IPoint itfPt = null;
            try
            {
                itfPt = (IPoint)c;
                Console.WriteLine(itfPt.Points);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }


            // Can we treat hex2 as IPointy?   
            Hexagon hex2 = new Hexagon("Peter");

            IPoint itfPt2 = hex2 as IPoint;
            if(itfPt2 != null)
            {
                Console.WriteLine("Points: {0}", itfPt2.Points);

            }
            else
                Console.WriteLine("OOPs! Not pointy!");

            // Make an array of Shapes.   
            Shape[] myShapes = {
                new Hexagon(),
                new Circle(),
                new Triangle("Joe"),
                new Circle("JoJo")} ; 

            for (int i = 0; i < myShapes.Length; i++)
            {     // Recall the Shape base class defines an abstract Draw()  
                  // member, so all shapes know how to draw themselves. 
                myShapes[i].Draw(); 

                // Who's pointy?    
                if (myShapes[i] is IPoint)
                    Console.WriteLine("-> Points: {0}", ((IPoint) myShapes[i]).Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                

                // Can I draw you in 3D?   
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);

                Console.WriteLine();
            }




            Console.ReadLine();
        }
        // I'll draw anyone supporting IDraw3D. 
        static void DrawIn3D(IDraw3D itf3d) 
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }
    }
}
