
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the text-based calendar!");
        
        string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        
        Console.WriteLine("Enter a month (1-12):");
        int month = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter a year:");
        int year = Convert.ToInt32(Console.ReadLine());
        
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int startDay = (int)firstDayOfMonth.DayOfWeek;
        
        Console.WriteLine();
        
        Console.WriteLine($"{firstDayOfMonth.ToString("MMMM")} {year}");
        Console.WriteLine("---------------------------");
        
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"{daysOfWeek[i]} ");
        }
        Console.WriteLine();
        
        for (int i = 0; i < startDay; i++)
        {
            Console.Write("    ");
        }
        
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day.ToString().PadLeft(2)}  ");
            
            if ((startDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        
        Console.WriteLine();
    }
}
