using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomEnumeratorWithYield
{
    class Garage: IEnumerator
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
                throw new NotImplementedException();
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Car c in carArray)
            {
                yield return c;
            }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetTheCars(bool ReturnRevers)
        {
            if (ReturnRevers)
            {
                for (int i = carArray.Length; i != 0; i--)
                {
                    yield return carArray[i - 1];
                }
            }
            else
            {
                foreach (Car c in carArray)
                {
                    yield return c;                        
                }
            }
        }
    }
}
