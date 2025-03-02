
using System;

class Calendar
{
    static void Main()
    {
        int year, month;

        Console.WriteLine("Enter the year:");
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Invalid input. Please try again.");
        }

        Console.WriteLine("Enter the month (1-12):");
        while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
        {
            Console.WriteLine("Invalid input. Please try again.");
        }

        Console.WriteLine("\n{0} {1}\n", GetMonthName(month), year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        DateTime date = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int offset = (int)date.DayOfWeek;

        for (int i = 0; i < offset; i++)
        {
            Console.Write("    ");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write("{0,3}", day);
            date = date.AddDays(1);

            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine();
            }
        }
    }

    static string GetMonthName(int month)
    {
        return new DateTime(1, month, 1).ToString("MMMM");
    }
}
