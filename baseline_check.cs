
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the dodecagon:");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 12));
        double area = 6 * sideLength * apothem;

        Console.WriteLine("The area of the regular dodecagon is: " + area);
    }
}
