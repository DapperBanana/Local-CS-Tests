
using System;

class CalendarProgram
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based Calendar Program!");
        Console.WriteLine();

        // Get current date
        DateTime currentDate = DateTime.Today;

        // Display current month and year
        Console.WriteLine(currentDate.ToString("MMMM yyyy"));
        Console.WriteLine("Sun  Mon  Tue  Wed  Thu  Fri  Sat");

        int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
        DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

        int currentDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

        int dayCounter = 1;
        int lineCounter = 1;

        // Print empty spaces for days before the first day of the month
        for (int i = 0; i < currentDayOfWeek; i++)
        {
            Console.Write("     ");
        }

        // Print the days of the month
        while (dayCounter <= daysInMonth)
        {
            Console.Write(dayCounter.ToString().PadLeft(5));

            if ((currentDayOfWeek + dayCounter) % 7 == 0)
            {
                Console.WriteLine();
                lineCounter++;
            }

            dayCounter++;
        }

        // Print empty spaces for days after the last day of the month
        while ((currentDayOfWeek + dayCounter) % 7 != 0)
        {
            Console.Write("     ");
            dayCounter++;
        }

        Console.WriteLine();
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
