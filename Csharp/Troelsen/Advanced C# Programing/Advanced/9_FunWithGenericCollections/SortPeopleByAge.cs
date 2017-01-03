using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_FunWithGenericCollections
{
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age > y.Age)
                return 1;
            if (x.Age < y.Age)
                return -1;

            return 0;
        }
    }
}
