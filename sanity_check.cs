
using System;

class Program
{
    static void Main()
    {
        DateTime currentDate = DateTime.Today;
        int year = currentDate.Year;
        int month = currentDate.Month;
        int daysInMonth = DateTime.DaysInMonth(year, month);
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int startingDay = (int)firstDayOfMonth.DayOfWeek;

        Console.WriteLine("Current Month: {0}", currentDate.ToString("MMMM yyyy"));
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        for (int i = 0; i < startingDay; i++)
        {
            Console.Write("    ");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(day.ToString().PadLeft(2) + " ");

            if ((day + startingDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }
}
