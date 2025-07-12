
using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        
        if(IsLeapYear(year))
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
        // Leap year rules:
        // If a year is divisible by 4, it is a leap year
        // If a year is divisible by 100, it is not a leap year, unless it is also divisible by 400
        
        if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
