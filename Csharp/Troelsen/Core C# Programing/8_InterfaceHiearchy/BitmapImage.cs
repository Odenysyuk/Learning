using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_InterfaceHiearchy
{
    class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing....");
        }

        public void DrawInBOundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing in a box....");
        }

        public void DrawUpsideDrown()
        {
            Console.WriteLine("Drawing upside down....");
        }
    }
}
