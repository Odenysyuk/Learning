using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialized
{
    struct Medicines
    {
        String name;
        Double value;
        Int32 number;

        public Double GetSum()
        {
            return value * number;
        }
    }

    class Patient
    {
        String name;
        Int32 age;
        String department;
        List<String> diseases = new List<string>();
        String doctor;
        List<Medicines> ListOfMeicines = new List<Medicines>();
        Double Total;

        public Patient(String n, Int32 a, String dep, String dis, String doc, Medicines ll)
        {
            name = n;
            age = a;
            department = dep;
            diseases.Add(dis);
            doctor = doc;
            ListOfMeicines.Add(ll);
            Total = ll.GetSum();

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
