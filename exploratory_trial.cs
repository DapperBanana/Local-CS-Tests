
using System;

class Calendar
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-based Calendar!");
        
        // Get current date
        DateTime currentDate = DateTime.Now;

        // Get the number of days in the current month
        int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

        // Print the calendar header
        Console.WriteLine($"{currentDate.ToString("MMMM")} {currentDate.Year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Get the day of the week for the first day of the month
        int startDay = (int)new DateTime(currentDate.Year, currentDate.Month, 1).DayOfWeek;

        // Print empty spaces for days before the first day of the month
        for (int i = 0; i < startDay; i++)
        {
            Console.Write("    ");
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3}");

            // Break line after Saturday
            if ((day + startDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }
}
