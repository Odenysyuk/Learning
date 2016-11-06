using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        public static void AddPlayer(ref Score[] array, ref Int32 size)
        {
            string name;
            Score[] temp = new Score[size + 1];
            for (int i = 0; i < size; i++)
            {
                temp[i] = array[i];
            }

            Console.WriteLine("Enter name players:");
            name = Console.ReadLine();
            temp[size] = new Score(name, 0);
            ++size;

            array = temp;
        }

        public static void DelPlayer(ref Score[] array, ref Int32 size, Int32 pos)
        {
            if (size == 0) return;
            if (pos >= size) return;

            Score[] temp = new Score[size - 1];
            for (int i = 0; i < size - 1; i++)
            {
                if (i < pos)
                    temp[i] = array[i];
                else if (i > pos)
                    temp[i - 1] = array[i];
            }

            --size;

            array = temp;
        }

        public static void ShowPlayers(Score[] array)
        {
            foreach (Score el in array)
            {
                el.Show();
            }

        }

        static void Main(string[] args)
        {

            Int32 size = 0;
            Score[] array = new Score[size];

            try
            {
                AddPlayer(ref array, ref size);
                ShowPlayers(array);

                DelPlayer(ref array, ref size, 0);
                ShowPlayers(array);

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range Exception");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }           
        }
    }

    class Score
    {

        String name;
        Int32 amount;
        static Int32 players;
        static Score BestPalyer;
        const Int32 Max = 100;

        public String Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public Int32 Amount
        {
            get { return Amount; }
            set { Amount = value; }
        }

        public Score()
        {
            name = "default";
            amount = 0;
        }

        public Score(String n, Int32 a)
        {
            this.name = n;
            this.amount = a;
        }

        static Score()
        {
            players = 0;
            BestPalyer = null;
        }

        public void Show()
        {
            Console.WriteLine("Name: {0}, score: {1}", name, amount);
        }

        public void AddScore(Int32 s)
        {
            if ((amount + s) > Max) return;
            this.amount = +s;
        }

        public void DivScore(Int32 s)
        {
            if ((amount - s) < 0) return;
            this.amount = -s;
        }

        public static void SetBestPlayers(Score []array)
        {
            Score temp = null;
            Int32 MaxTemp = 0;

            foreach (Score el in array)
            {
                if (MaxTemp < el.amount)
                    temp = el;
            }
            Score.BestPalyer = temp;
        }

        public void Play(Int32 min)
        {
            for(int i = 0; i < min; i++)
                this.AddScore(1);
        }

        public static Score operator ++(Score el)
        {
            el.AddScore(1);
            return el;
        }

        public static Score operator --(Score el)
        {
            el.DivScore(1);
            return el;
        }

        public static explicit operator int(Score el)
        {
            return el.amount;
        }

        public static explicit operator double(Score el)
        {
            return el.amount + 0.001;
        }

        public static explicit operator Score(int  a)
        {
            return new Score("default", a);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;

            Score temp = (Score)obj;

            if (amount == temp.amount) return true;

            return false;
        }


         
        public static bool operator ==(Score obj1, Score obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;

            if (obj1.amount == obj2.amount) return true;
            return false;
        }

        public static bool operator !=(Score obj1, Score obj2)
        {
            return !(obj1 == obj2);
        }

       
    }


}
