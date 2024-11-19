
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the decagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 10));
        double area = (5 * sideLength * apothem);

        Console.WriteLine($"The area of the regular decagon is: {area}");
    }
}
