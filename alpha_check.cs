
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the regular decagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double area = (5 * sideLength * sideLength) / (4 * Math.Tan(Math.PI / 10));

        Console.WriteLine($"The area of the regular decagon is: {area}");
    }
}
