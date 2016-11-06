using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLock
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock clock1 = new Clock();
            clock1.Hour = 36;
            clock1.Minute = 66;
            clock1.Second = 60;
              Console.WriteLine(clock1);
        }
    }


    class Clock
    {

        public delegate void PrintCLock(Int32 hour, Int32 minute, Int32 second);
        public event PrintCLock EventPrintClock;
        Int32 hour;
        Int32 minute;
        Int32 second;

        public Int32 Hour
        {
            set { hour = (value + 24) % 24; }
            get { return hour; }
        }

        public Int32 Minute
        {
            set { minute = (value + 60) % 60; }
            get { return minute; }
        }

        public Int32 Second
        {
            set { second = (value + 60) % 60; }
            get { return second; }
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}", hour, minute, second);
        }

        public void Print(Int32 hour, Int32 minute, Int32 second)
        {
            Console.Write(String.Format("{0}:{1}:{2}", hour, minute, second));
        }

        public void AddMinute(Int32 del)
        {
            var tmp = minute + del;
            if(tmp > 60)
                minute = (minute + 60) % 60;

        }

        public void DoEvent()
        {
            if(EventPrintClock == null)
            {
                EventPrintClock(hour, minute, second);
            }

        }


    }

}

