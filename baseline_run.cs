
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        
        // Keep calculating sum of digits until number becomes a single-digit number
        while (number > 9)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            number = sum;
        }
        
        Console.WriteLine("Single-digit number: " + number);
    }
}
