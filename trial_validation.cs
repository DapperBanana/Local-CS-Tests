
using System;

class Calendar
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based Calendar");

        int year, month;

        // Get user input for year
        while (true)
        {
            Console.Write("Enter the year: ");
            if (int.TryParse(Console.ReadLine(), out year) && year >= 1)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid year.");
        }

        // Get user input for month
        while (true)
        {
            Console.Write("Enter the month (1-12): ");
            if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid month (1-12).");
        }

        // Display calendar for the given year and month
        DateTime date = new DateTime(year, month, 1);
        Console.WriteLine($"Calendar for {date:MMMM yyyy}");
        Console.WriteLine("  Sun  Mon  Tue  Wed  Thu  Fri  Sat");

        int daysInMonth = DateTime.DaysInMonth(year, month);
        int currentDay = 1;

        while (currentDay <= daysInMonth)
        {
            for (int i = 0; i < 7; i++)
            {
                if (currentDay == 1 && i < (int)date.DayOfWeek)
                {
                    Console.Write("     ");
                }
                else
                {
                    if (currentDay <= daysInMonth)
                    {
                        Console.Write($"{currentDay,4}");
                        currentDay++;
                    }
                }
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
