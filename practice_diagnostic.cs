
using System;

class Program
{
    static void Main()
    {
        double number;

        Console.Write("Enter a number: ");
        if (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        if (number < 0)
        {
            Console.WriteLine("Square root of a negative number is not a real number.");
        }
        else
        {
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is: {squareRoot}");
        }
    }
}
