using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ComparableCar
{
    class PetNameCompare : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Car t1 = x as Car;
            Car t2 = y as Car;
            if(t1 != null && t2 != null)
            {
                return String.Compare(t1.petName, t2.petName);
            }

            throw new ArgumentException("Parameters are not Car's type");
        }
    }
}
