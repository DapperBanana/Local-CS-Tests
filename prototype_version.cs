
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        
        Console.WriteLine("Enter the side length of the hexadecagon:");
        sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 16));
        double area = (16 * sideLength * apothem) / 2;

        Console.WriteLine($"The area of the regular hexadecagon is: {area}");
    }
}
