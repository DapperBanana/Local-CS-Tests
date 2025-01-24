
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the year:");
        int year = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the month (1-12):");
        int month = int.Parse(Console.ReadLine());
        
        DateTime date = new DateTime(year, month, 1);
        
        Console.WriteLine(" Sun Mon Tue Wed Thu Fri Sat");
        
        int offset = (int)date.DayOfWeek;
        
        for (int i = 0; i < offset; i++)
        {
            Console.Write("    ");
        }
        
        while (date.Month == month)
        {
            Console.Write(date.Day.ToString().PadLeft(4));
            
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine();
            }
            
            date = date.AddDays(1);
        }
        
        Console.WriteLine();
    }
}
