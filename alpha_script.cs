
using System;

class Program
{
    static bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return true;
        }

        return false;
    }

    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

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
