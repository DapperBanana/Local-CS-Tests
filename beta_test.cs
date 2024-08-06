
using System;

class Program
{
    static void Main()
    {
        int sideLength;
        double area;

        Console.Write("Enter the side length of the decagon: ");
        sideLength = Convert.ToInt32(Console.ReadLine());

        area = (5 * sideLength * sideLength) / (4 * Math.Tan(Math.PI / 10));

        Console.WriteLine($"The area of the regular decagon is {area}");
    }
}
