
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number = number / 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
