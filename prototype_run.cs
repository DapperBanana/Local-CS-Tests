
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the year:");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the month:");
        int month = Convert.ToInt32(Console.ReadLine());

        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);

        Console.WriteLine($"{firstDayOfMonth:MMMM yyyy}");
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        for (int i = 0; i < (int)firstDayOfMonth.DayOfWeek; i++)
        {
            Console.Write("   ");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day, 2} ");

            if ((int)(firstDayOfMonth.AddDays(day).DayOfWeek) == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
    }
}
