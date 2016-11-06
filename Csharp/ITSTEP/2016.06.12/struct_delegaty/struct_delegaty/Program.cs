using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_delegaty
{
    public struct Product
    {
        private Int32 Code;
        private String Name;
        private Double Price;
        static Int32 MaxCode;

        public Product(Int32 C, String N, Double P)
        {
            Code = C;
            Name = N;
            Price = P;
        }

        static Product()
        {
            ++MaxCode;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}: {2}", Code, Name, Price);
        }

        public Int32 code
        {
            set { Code = value; }
            get { return Code; }
        }

        public String name
        {
            set { Name = value; }
            get { return Name; }
        }

        public Double price
        {
            set { Price = value; }
            get { return Price; }
        }
    }

    public struct Customer
    {
        private Int32 Code;
        private String Name;
        private String Address;
        private String Telepphone;
        static Int32 MaxCode;

        public Int32 code
        {
            get { return Code; }
            set { Code = value; }
        }
        public String name
        {
            get { return Name; }
            set { Name = value; }
        }

        public String address
        {
            get { return Address; }
            set { Address = value; }
        }

        public String telepphone
        {
            get { return Telepphone; }
            set { Telepphone = value; }
        }

        public Customer(Int32 c, String n, String a, String t)
        {
            Code = c;
            Name = n;
            Address = a;
            Telepphone = t;
        }

        static Customer()
        {
            ++MaxCode;
        }

        public override string ToString()
        {
            return String.Format("{0}. {1}. Address: {2}, telephone:{3}", Code, Name, Address, Telepphone);
        }
    }

    public struct OrderProduct
    {
        String Name;
        Int32 Amout;

        public OrderProduct(String n, Int32 a)
        {
            Name = n;
            Amout = a;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} \n", Name, Amout);
        }
    }

    public struct OrderCustomer
    {
        Int32 Number;
        Customer Customer;
        DateTime Data;
        OrderProduct[] goods;
        Double Amount;
        static Int32 MaxNumber;

        public OrderCustomer(Int32 N, Customer C, DateTime D)
        {
            Number = N;
            Customer = C;
            Data = D;
            goods = null;
            Amount = 0;
        }

        Int32 number
        {
            set { Number = value; }
            get { return Number; }
        }

        Customer customer
        {
            set { Customer = value; }
            get { return Customer; }
        }

        DateTime data
        {
            set { Data = value; }
            get { return Data; }
        }

        static OrderCustomer()
        {
            ++MaxNumber;

        }

        public override string ToString()
        {
            String format = String.Format("№{0} / {1} \n Customer: {2} \n Amount: {3} \n", Number, Data, Customer, Amount);
            foreach (OrderProduct el in goods)
            {
                format += el;
            }
            return format;
        }


    }

    



    public delegate Boolean IsElemement(Object el);

     class Program
    {
       

        static Boolean OperationInt(Object i)
        {
            return ((Int32)i > 100) ? true: false;
        }

       static Boolean OperationDouble(Object i)
        {
            return ((Double)i == 3.14) ? true : false;
        }

        static Boolean OperationChar(Object i)
        {
            return ((Char)i > 'a' && (Char)i < 'd') ? true : false;
        }

        static  Int32 FindElement(Object[] array, IsElemement func)
        {
            Int32 i = 0;

            foreach (Object el in array)
            {
                if (func(el)) return i;
                i++;
            }
            return -1;
        }

        static void Main(string[] args)
        {

            Object[] arr1 = { 10, 25, 163 };
            Object[] arr2 = { 10.5, 3.14, 0};
            Object[] arr3 = { 'p', 'q' };

            Console.WriteLine("Int32 [], res = {0}", FindElement(arr1, new IsElemement(OperationInt)));
            Console.WriteLine("Double [], res = {0}", FindElement(arr2, new IsElemement(OperationDouble)));
            Console.WriteLine("Char [], res = {0}", FindElement(arr3, new IsElemement(OperationChar)));

        }


    }
}


namespace Clocker
{
    class Clock
    {
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
    }

    class ClockMain
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

}