
using System;

namespace LeapYearCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check if it is a leap year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }

        static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
