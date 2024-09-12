
using System;

class TextCalendar
{
    static void Main()
    {
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());
        
        DateTime startDate = new DateTime(year, month, 1);
        int numDaysInMonth = DateTime.DaysInMonth(year, month);
        int dayOfWeek = (int)startDate.DayOfWeek;
        
        Console.WriteLine("    Sun    Mon    Tue    Wed    Thu    Fri    Sat");
        
        for (int i = 0; i < dayOfWeek; i++)
        {
            Console.Write("        ");
        }
        
        for (int day = 1; day <= numDaysInMonth; day++)
        {
            Console.Write($"   {day, 2}");
            
            if ((day + dayOfWeek) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
