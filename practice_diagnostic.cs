
using System;

class Program
{
    static void Main()
    {
        // Get the current month and year
        DateTime date = DateTime.Now;
        int year = date.Year;
        int month = date.Month;

        // Display the calendar header
        Console.WriteLine($"     {date.ToString("MMMM")} {year}");
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        // Get the first day of the month and total number of days in the month
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int dayOfWeek = (int)firstDayOfMonth.DayOfWeek;

        // Print the calendar
        for (int i = 0; i < dayOfWeek; i++)
        {
            Console.Write("   ");
        }
        
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write("{0,2} ", day);

            if ((day + dayOfWeek) % 7 == 0 || day == daysInMonth)
            {
                Console.WriteLine();
            }
        }
    }
}
