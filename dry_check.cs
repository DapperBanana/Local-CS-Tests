
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the regular heptagon:");
        double sideLength = double.Parse(Console.ReadLine());

        double apothemLength = sideLength / (2 * Math.Tan(Math.PI / 7));
        double perimeter = 7 * sideLength;
        double area = 0.5 * perimeter * apothemLength;

        Console.WriteLine($"The area of the regular heptagon is: {area}");
    }
}
