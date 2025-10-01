
using System;

class Program
{
    static void Main()
    {
        double number, squareRoot;

        // Input number from user
        Console.WriteLine("Enter a number to find its square root:");
        number = Convert.ToDouble(Console.ReadLine());

        // Calculate square root using Math.Sqrt method
        squareRoot = Math.Sqrt(number);

        // Print the result
        Console.WriteLine($"Square root of {number} is {squareRoot}");
    }
}
