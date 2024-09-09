
using System;

class Program
{
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

    static void Main()
    {
        int year;
        Console.Write("Enter a year: ");
        year = Convert.ToInt32(Console.ReadLine());

        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}
