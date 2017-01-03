using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_FunWithGenericCollections
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
