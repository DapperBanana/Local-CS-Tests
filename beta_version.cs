
using System;

class Calendar
{
    static void Main()
    {
        // Get the current date and time
        DateTime now = DateTime.Now;

        // Display the current month and year
        Console.WriteLine(now.ToString("MMMM yyyy"));
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        // Get the first day of the month
        DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);

        // Get the day of the week for the first day of the month
        int dayOfWeek = (int)firstDayOfMonth.DayOfWeek;

        // Start from the beginning of the week
        for (int i = 0; i < dayOfWeek; i++)
        {
            Console.Write("   ");
        }

        // Iterate through the days of the month
        int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
        for (int i = 1; i <= daysInMonth; i++)
        {
            Console.Write(i.ToString().PadLeft(2) + " ");

            // Move to the next line if it's the end of the week
            dayOfWeek = (dayOfWeek + 1) % 7;
            if (dayOfWeek == 0)
            {
                Console.WriteLine();
            }
        }

        // Add a new line at the end
        Console.WriteLine();
    }
}
