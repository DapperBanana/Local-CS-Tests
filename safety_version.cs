
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the side length of the regular decagon: ");
        double sideLength = double.Parse(Console.ReadLine());

        double apothemLength = sideLength / (2 * Math.Tan(Math.PI / 10));
        double area = (5 * sideLength * apothemLength) / 2;

        Console.WriteLine($"The area of the regular decagon is: {area}");
    }
}
