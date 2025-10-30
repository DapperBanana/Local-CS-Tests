
using System;

class Program
{
    static void Main()
    {
        // Ask user to enter a number
        Console.Write("Enter a number to find its square root: ");
        double number = Convert.ToDouble(Console.ReadLine());

        // Calculate and display the square root
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine($"The square root of {number} is {squareRoot}");
    }
}
