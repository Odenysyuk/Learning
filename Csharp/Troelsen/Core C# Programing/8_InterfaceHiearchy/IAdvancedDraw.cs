using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_InterfaceHiearchy
{
    public interface IAdvancedDraw: IDrawable
    {
        void DrawInBOundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDrown();
    }
}
