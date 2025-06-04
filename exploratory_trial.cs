
using System;

class Program
{
    static void Main()
    {
        string[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        Console.WriteLine("Enter the year:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the month (1-12):");
        int month = int.Parse(Console.ReadLine());

        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int currentDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

        Console.WriteLine($"\n{firstDayOfMonth.ToString("MMMM")} {year}\n");

        foreach (string day in daysOfWeek)
        {
            Console.Write($"{day}\t");
        }

        Console.WriteLine();

        for (int i = 0; i < currentDayOfWeek; i++)
        {
            Console.Write("\t");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day}\t");
            currentDayOfWeek++;

            if (currentDayOfWeek == 7)
            {
                Console.WriteLine();
                currentDayOfWeek = 0;
            }
        }

        Console.WriteLine();
    }
}
