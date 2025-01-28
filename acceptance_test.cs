
using System;

class Program
{
    static void Main()
    {
        double sideLength, apothem, area;

        Console.Write("Enter the side length of the octagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        apothem = sideLength / (2 * Math.Tan(Math.PI / 8));
        area = 4 * sideLength * apothem;

        Console.WriteLine("The area of the octagon is: {0}", area);
    }
}
