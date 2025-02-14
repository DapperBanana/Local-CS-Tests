
using System;

class CalendarProgram
{
    static void Main()
    {
        Console.WriteLine("Welcome to the text-based calendar program!");

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);

        Console.WriteLine($"    {startDate:MMMM} {year}");
        Console.WriteLine(" Su Mo Tu We Th Fr Sa");

        for (int i = 0; i < (int)startDate.DayOfWeek; i++)
        {
            Console.Write("   ");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3}");
            if ((int)(startDate.AddDays(day).DayOfWeek) == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
