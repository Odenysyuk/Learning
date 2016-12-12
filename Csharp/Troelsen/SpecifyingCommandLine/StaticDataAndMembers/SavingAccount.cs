using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate;

        public SavingAccount(double balance)
        {
           this. currBalance = balance;
        }

        public static double InterestRate { get { return currInterestRate; } set { currInterestRate = value; } }

        static SavingAccount()
        {
            Console.WriteLine("In static ctor");
            currInterestRate = 0.04;

        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }

        public static void  SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
    }
}
