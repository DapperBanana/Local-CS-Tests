
using System;

class Calendar
{
    static void Main()
    {
        // Get the current date
        DateTime currentDate = DateTime.Today;

        // Display the calendar header
        Console.WriteLine("-----------" + currentDate.ToString("MMMM") + " " + currentDate.Year + "-----------");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Find first day of the month
        DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

        // Find the day of the week of the first day of the month
        int offset = (int)firstDayOfMonth.DayOfWeek;

        // Loop through days in the month
        for (int i = 0; i < offset; i++)
        {
            Console.Write("    ");
        }

        int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(day.ToString().PadLeft(3));
            offset++;
            if (offset % 7 == 0)
                Console.WriteLine();
        }

        Console.WriteLine();
    }
}
