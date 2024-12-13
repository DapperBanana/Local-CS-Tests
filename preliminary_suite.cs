
using System;

class Program
{
    static void Main()
    {
        int sideLength = 5; // Example side length of the hexadecagon

        double area = 4 * sideLength * sideLength * Math.Sqrt(3) * (1 + Math.Sqrt(2));

        Console.WriteLine("Area of the regular hexadecagon with side length {0} is: {1}", sideLength, area);
    }
}
