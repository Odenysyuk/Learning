using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumType
{
    class Program
    {
        enum EmpType
        {
            Manager = 10,
            Creent,
            Contractor,
            VicePresident
        };

        enum EmpTypeShort :short
        {
            Manager = 10,
            Creent,
            Contractor,
            VicePresident = 999
        };

        static void Main(string[] args)
        {
            Console.WriteLine("=> Enum");
            AskForBonus(emp:EmpType.Manager);
            Console.WriteLine("{0}", Enum.GetUnderlyingType(EmpType.Manager.GetType()));


            Console.WriteLine("Name: {0}", EmpType.Manager.ToString());
            Console.WriteLine("Value: {0}", (short)EmpType.Manager);

            //Console.WriteLine(Enum.Format(EmpType.Manager.GetType(), (int)EmpType.Manager, ""));
            EnumerationValue(DayOfWeek.Friday);
            EnumerationValue(EmpType.Contractor);
            EnumerationValue(ConsoleColor.Black);


        }

        static void AskForBonus(EmpType emp)
        {
            switch (emp)
            {
                case EmpType.Manager:
                    Console.WriteLine("Manager bonus");
                    break;
                case EmpType.Creent:
                    Console.WriteLine("Greent bonus");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("Contractor bonus");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Contractor bonus");
                    break;
            }
        }

        static void EnumerationValue(Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type:{0}", Enum.GetUnderlyingType(e.GetType()));

            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has got {0} members", enumData.Length);

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, value: {0:D}", enumData.GetValue(i));
            }
            Console.WriteLine();


        }

    }
}
