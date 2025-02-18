
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the sector:");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the angle of the sector in degrees:");
        double angle = Convert.ToDouble(Console.ReadLine());

        double area = (Math.PI * radius * radius * angle) / 360;

        Console.WriteLine($"The area of the sector with radius {radius} and angle {angle} degrees is {area}");
    }
}
