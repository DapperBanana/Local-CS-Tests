using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a year: ");
        int year;
        if (int.TryParse(Console.ReadLine(), out year))
        {
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid year.");
        }
    }

    static bool IsLeapYear(int year)
    {
        // A year is a leap year if it's divisible by 4 and not by 100,
        // or if it's divisible by 400.
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}