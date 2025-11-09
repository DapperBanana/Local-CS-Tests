
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        double squareRoot = Math.Sqrt(number);

        Console.WriteLine($"Square root of {number} is: {squareRoot}");
    }
}
