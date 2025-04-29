
using System;

class Calendar
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based Calendar!");
        Console.WriteLine();

        // Get current date
        DateTime currentDate = DateTime.Today;
        int year = currentDate.Year;
        int month = currentDate.Month;

        // Display the calendar for the current month
        DisplayCalendar(year, month);

        // Wait for user input to exit the program
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void DisplayCalendar(int year, int month)
    {
        Console.WriteLine("  Sun  Mon  Tue  Wed  Thu  Fri  Sat ");
        
        DateTime startDate = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int dayOfWeek = (int)startDate.DayOfWeek;

        for (int i = 0; i < dayOfWeek; i++)
        {
            Console.Write("     ");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,4}");

            if (++dayOfWeek == 7)
            {
                Console.WriteLine();
                dayOfWeek = 0;
            }
        }
    }
}
