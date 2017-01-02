using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_InterfaceHiearchy
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBOundingBox(10, 10, 10, 10);
            myBitmap.DrawUpsideDrown();

            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.Draw();
        }
    }
}
