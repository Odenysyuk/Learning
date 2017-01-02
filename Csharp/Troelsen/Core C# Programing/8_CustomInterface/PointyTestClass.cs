using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomInterface
{
    class PointyTestClass : IPoint, ICloneable
    {
        public byte Points
        {
            get
            {
                return 2;
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
