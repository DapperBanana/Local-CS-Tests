
using System;

class Program
{
    static void Main()
    {
        double radius, angle, area;

        Console.Write("Enter the radius of the sector: ");
        radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the angle of the sector in degrees: ");
        angle = Convert.ToDouble(Console.ReadLine());

        // Convert angle from degrees to radians
        angle = angle * Math.PI / 180;

        area = (Math.PI * Math.Pow(radius, 2) * angle) / (2 * Math.PI);

        Console.WriteLine($"The area of the sector is: {area}");
    }
}
