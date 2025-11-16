
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of a side of the hendecagon:");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 11));
        double perimeter = 11 * sideLength;

        double area = 0.5 * perimeter * apothem;
        
        Console.WriteLine($"The area of the regular hendecagon is: {area}");
    }
}
