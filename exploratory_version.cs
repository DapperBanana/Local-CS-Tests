
using System;

class Program
{
    static void Main()
    {
        double number;
        Console.Write("Enter a number: ");
        number = Convert.ToDouble(Console.ReadLine());

        double squareRoot = Math.Sqrt(number);

        Console.WriteLine($"The square root of {number} is {squareRoot}");
    }
}
