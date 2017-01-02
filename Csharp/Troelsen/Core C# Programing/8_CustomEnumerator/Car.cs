﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CustomEnumerator
{
    class Car
    {
        public int currSpeed;
        public string petName;

        public void SpeedUp(int delta)
        {
            this.currSpeed += delta;

        }
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH", petName, currSpeed);
        }

        public Car()
        {
            this.currSpeed = 15;
            this.petName = "Chuck";
        }

        public Car(string petName, int currSpeed)
        {
            this.currSpeed = currSpeed;
            this.petName = petName;
        }

    }
}
