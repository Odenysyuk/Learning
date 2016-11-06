using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        
    }

    struct Address
    {
        String city;
        String street;
        String numberOfFlat;

        public Address(String c, String s, String n)
        {
            city = c;
            street = s;
            numberOfFlat = n;
        }

    }

    struct Flat
    {
        public Int32 NumberOfFlat;

        public Flat(Int32 n)
        {
            NumberOfFlat = n;
        }
    }

    class Customer
    {
        String Name;
        String NumberOfPhone;
        Boolean empty;

        public Customer()
        {
            Name = "";
            NumberOfPhone = "";
            empty = true;
        }

        public Customer(String n, String ph, Boolean e = true)
        {
            Name = n;
            NumberOfPhone = ph;
            empty = e;
        }

       public Boolean Empty
        {
            set{ empty = value; }
            get{ return empty;}
        }

    }

    class DataBase
    {
        static SortedList<Flat, Address> ListOfFlat;
        static SortedList<Address, Customer> ListOfFreeFlat;

        static Boolean AddFlat(Flat obj, Address ads) {

            if (ListOfFlat.ContainsKey(obj))
            {
                Console.WriteLine("This flat contains data base!!!");
                return false;
            }

            try
            {
                ListOfFlat.Add(obj, ads);
                ListOfFreeFlat.Add(ads, new Customer());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
            return false;
        }

        static Boolean deleteFlat(Flat obj)
        {
            if (ListOfFlat.ContainsKey(obj) == false)
            {
                Console.WriteLine("This flat doesn't contains data base!!!");
                return false;
            }
            Address ads = ListOfFlat[obj];

            try
            {
                ListOfFreeFlat.Remove(ads);
                ListOfFlat.Remove(obj);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            

            return true;
        }

        static Boolean deleteFlatWuthCustomer(Customer cl)
        {

            if (cl.Empty == false)
            {
                Console.WriteLine("This customer isn't find!!!");
                return false;
            }

            Int32 index = ListOfFreeFlat.IndexOfValue(cl);
            Address ads = ListOfFreeFlat.Keys[index];
            try
            {
                ListOfFreeFlat.RemoveAt(index);
                ListOfFlat.RemoveAt(ListOfFlat.IndexOfValue(ads));
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
            return true;
        }

        static Boolean SearcAllFlatNumbersFlat(Int32 NumbersOfFlat)
        {
            foreach(Flat el in ListOfFlat.Keys)
            {               
               if( el.NumberOfFlat == NumbersOfFlat)
                {
                    Console.WriteLine(ListOfFlat[el]);

                }                
            }

            return true;
        }

        static Boolean SearcAllFreeFlat()
        {
            foreach (Address el in ListOfFreeFlat.Keys)
            {
                if (ListOfFreeFlat[el].Empty == true)
                {
                    Console.WriteLine(ListOfFreeFlat[el]);

                }
            }

            return true;
        }

        static Boolean AddReserve(Flat flat_temp, Customer client)
        {
            Address ads = ListOfFlat[flat_temp];
            ListOfFreeFlat[ads] = client;

            return true;
        }

        static Boolean EditFlat(Flat flat_temp, Address new_ads)
        {
            ListOfFlat[flat_temp] = new_ads;
            return true;
        }
    }
}


namespace Collections
{
    class NamePoint<K> 
    {
        K Name;
        public NamePoint(K n)
        {
            Name = n;
        }
   
    }

    struct Point<T>
    {
        public T x;
        public T y;
        public Point(T x_, T y_) {
            x = x_;
            y = y_;
        }

    }
    
    class Points<T, K> 
    {
        NamePoint<K> name;
        Point<T> point;

        public Points(K n, T x, T y)
        {
            name = new NamePoint<K>(n);
            point = new Point<T>(x, y);


        }

        Boolean IsFirstQuarter(Point<int> p) {
            return (p.x > 0 && p.y > 0);
        }

        Boolean IsFirstQuarter(Point<double> p)
        {
            return (p.x > 0 && p.y > 0);
        }

        Boolean IsFSecondQuarter(Point<int> p)
        {
            return (p.x < 0 && p.y > 0);
        }

        Boolean IsFSecondQuarter(Point<double> p)
        {
            return (p.x < 0 && p.y > 0);
        }

        Boolean IsThirddQuarter(Point<int> p)
        {
            return (p.x < 0 && p.y < 0);
        }

        Boolean IsThirddQuarter(Point<double> p)
        {
            return (p.x < 0 && p.y < 0);
        }

    }

   
    class ProgramMain
    {
        static void Main(string[] args)
        {

        }


    }

   
}