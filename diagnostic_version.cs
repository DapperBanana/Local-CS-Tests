
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the year:");
        int year = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter the month (1-12):");
        int month = int.Parse(Console.ReadLine());
        
        DateTime date = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        
        Console.WriteLine($"      {date.ToString("MMMM")} {year}");
        Console.WriteLine(" Sun Mon Tue Wed Thu Fri Sat");
        
        for (int i = 1; i < (int)date.DayOfWeek; i++)
        {
            Console.Write("    ");
        }
        
        for (int i = 1; i <= daysInMonth; i++)
        {
            Console.Write($"{i, 4}");
            
            if (((int)date.AddDays(i).DayOfWeek) == 0)
            {
                Console.WriteLine();
            }
        }
        
        Console.ReadLine();
    }
}
