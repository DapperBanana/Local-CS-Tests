
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        double squareRoot = Math.Sqrt(number);
        
        Console.WriteLine($"The square root of {number} is {squareRoot}");
    }
}
