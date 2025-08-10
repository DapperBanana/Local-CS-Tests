
using System;

class Program
{
    static void Main()
    {
        double radius, angle;

        Console.Write("Enter the radius of the sector: ");
        radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the angle of the sector in degrees: ");
        angle = Convert.ToDouble(Console.ReadLine());

        double area = (Math.PI * radius * radius * angle) / 360;

        Console.WriteLine($"The area of the sector with radius {radius} and angle {angle} degrees is {area:F2}");
    }
}
