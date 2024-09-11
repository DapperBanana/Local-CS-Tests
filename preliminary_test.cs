
using System;

class Program
{
    static void Main()
    {
        const int numSides = 11;
        double sideLength, apothem, area;

        Console.WriteLine("Enter the side length of the hendecagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        area = 0.5 * numSides * sideLength * apothem;

        Console.WriteLine($"The area of the hendecagon is: {area}");
    }
}
