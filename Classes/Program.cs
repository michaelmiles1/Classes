using System;
using static System.Console;

namespace Classes
{
    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        public void PrintMessage()
        {
            WriteLine("Calculating Pay...");
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
        }
    }
}
