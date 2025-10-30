
using System;

class Program
{
    static void Main()
    {
        double number;
        double squareRoot;

        Console.Write("Enter a number: ");
        number = double.Parse(Console.ReadLine());

        squareRoot = Math.Sqrt(number);

        Console.WriteLine($"The square root of {number} is {squareRoot}");
    }
}
