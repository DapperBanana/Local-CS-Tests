
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the side of the pentagon:");
        double sideLength = double.Parse(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 5));
        double area = (5 * sideLength * apothem) / 2;

        Console.WriteLine("The area of the pentagon is: " + area);
    }
}
