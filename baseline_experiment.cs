
using System;

class Program
{
    static void Main()
    {
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;

        Console.WriteLine("Calendar for {0}/{1}:\n", month, year);

        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int currentDay = 1;

        // Print the headers for the calendar
        Console.WriteLine("  Su Mo Tu We Th Fr Sa");

        // Determine the day of the week for the first day of the month
        int offset = (int)firstDayOfMonth.DayOfWeek;

        // Print leading spaces before the first day of the month
        Console.Write(new string(' ', 3 * offset));

        // Print the days of the month
        while (currentDay <= daysInMonth)
        {
            Console.Write("{0, 3}", currentDay);
            if ((offset + currentDay) % 7 == 0)
            {
                Console.WriteLine();
            }
            currentDay++;
        }

        Console.WriteLine("\n");
    }
}
