using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomEnumerator
{
    class Garage: IEnumerable, IEnumerator
    {
        private Car[] carArray = new Car[4];
        int position = -1;

        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public object Current
        {
            get
            {
                return carArray[position];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            
            if(position == carArray.Length-1)
            {
                Reset();
                return false;
            }

            position++;
            return true;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
