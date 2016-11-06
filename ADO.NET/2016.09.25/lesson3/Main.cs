using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;

namespace AnimalsApplication
{
    enum Sex { male, female }

    [Serializable]
    abstract class Animal
    {
        public Sex sex { get; set; }
        public Int32 age { get; set; }
        public String breed { get; set; }

        public Animal(Sex s, Int32 a, String b)
        {
            this.sex = s;
            this.age = a;
            this.breed = b;
        }

        public Animal(Sex s, Int32 a) : this(s, a, "Default") { }
        public Animal(Sex s) : this(s, 0, "Default") { }
        public Animal() : this(Sex.male, 0, "Default") { }

        public override string ToString()
        {
            Contract.Ensures(!String.IsNullOrEmpty(Contract.Result<string>()), "result is null or empty.");
            return String.Format("{0}, {1}, {2}", sex, age, breed);
        }

        public virtual bool ToEat(Int32 number) { return true; }


        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            
        }

    }

    [Serializable]
    class Chicken : Animal
    {
        public bool isEgg { get; set; }
        private const Int32 numberFood = 15;

        public Chicken(Sex s = Sex.male, Int32 a = 0, String b = "default", bool i = false)
            : base(s, a, b)
        {
            this.isEgg = i;
        }


        public override bool ToEat(int number)
        {
            if (numberFood <= number)
            {
                this.isEgg = true;
                return true;
            }
            else
                this.isEgg = false;
            return false;
        }

        public override string ToString()
        {
            Contract.Ensures(!String.IsNullOrEmpty(Contract.Result<string>()), "result is null or empty.");
            return String.Format("Chicken: {0}, IsEgg: {1}", base.ToString(), isEgg);
        }

    }

    [Serializable]
    class Dog : Animal
    {
        public String alias { get; set; }
        private const Int32 numberFood = 10;

        public Dog(String al = "default", Sex s = Sex.male, Int32 a = 0, String b = "default")
            : base(s, a, b)
        {
            this.alias = al;
        }

        public override bool ToEat(int number)
        {
            if (numberFood <= number)
            {
                this.age += number / numberFood;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            Contract.Ensures(!String.IsNullOrEmpty(Contract.Result<string>()), "result is null or empty.");
            return String.Format("Dog: {0}, {1}", this.alias, base.ToString());
        }


    }

    [Serializable]
    class Fish : Animal
    {
        bool isAdult { get; set; }
        private const Int32 Adult = 5;

        public Fish(Sex s = Sex.male, Int32 a = 0, String b = "default", bool ad = false)
            : base(s, a, b)
        {
            this.isAdult = ad;
        }

        public override bool ToEat(int number = 10)
        {
            this.age++;
            if (isAdult == false || this.age >= Adult)
                this.isAdult = true;

            return true;
        }

        public override string ToString()
        {
            Contract.Ensures(!String.IsNullOrEmpty(Contract.Result<string>()), "result is null or empty.");
            return String.Format("Fish: {0}, is adult: {1}", base.ToString(), isAdult);
        }


    }


}
