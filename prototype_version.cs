
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to find its square root:");
        double number = Convert.ToDouble(Console.ReadLine());

        double squareRoot = Math.Sqrt(number);

        Console.WriteLine($"Square root of {number} is: {squareRoot}");
    }
}
