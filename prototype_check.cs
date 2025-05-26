
using System;

class Program
{
    static void Main()
    {
        // Ask for input from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Calculate the sum of digits
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        // Display the sum of digits
        Console.WriteLine("Sum of digits: " + sum);
    }
}
