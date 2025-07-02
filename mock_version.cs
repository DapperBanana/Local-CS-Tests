
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the hexagon: ");
        double sideLength = double.Parse(Console.ReadLine());

        double area = (3 * Math.Sqrt(3) * Math.Pow(sideLength, 2)) / 2;

        Console.WriteLine("The area of the regular hexagon is: " + area);
    }
}
