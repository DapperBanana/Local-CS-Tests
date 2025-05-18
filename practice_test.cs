
using System;

class Program
{
    static void Main()
    {
        DateTime date = DateTime.Today;
        
        Console.WriteLine("Calendar");
        Console.WriteLine("================");
        Console.WriteLine($"{date:MMMM} {date.Year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
        int currentDay = 1;
        int currentWeekDay = (int)date.DayOfWeek;

        // Print the days of the month
        while (currentDay <= daysInMonth)
        {
            for (int i = 0; i < 7; i++)
            {
                if (i < currentWeekDay)
                {
                    Console.Write("    ");
                }
                else if (currentDay <= daysInMonth)
                {
                    Console.Write($"{currentDay,3}");
                    currentDay++;
                }
                else
                {
                    Console.Write("   ");
                }

                if (i < 6)
                {
                    Console.Write(" ");
                }
            }

            currentWeekDay = 0;
            Console.WriteLine();
        }
    }
}
