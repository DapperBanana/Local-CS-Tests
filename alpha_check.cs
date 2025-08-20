
using System;

class Program
{
    static void Main()
    {
        const int sides = 11;
        double sideLength, apothem, area;

        Console.WriteLine("Enter the side length of the hendecagon:");
        sideLength = Convert.ToDouble(Console.ReadLine());

        apothem = sideLength / (2 * Math.Tan(Math.PI / sides));
        area = (sides * sideLength * apothem) / 2;

        Console.WriteLine("The area of the hendecagon is: " + area);
    }
}
