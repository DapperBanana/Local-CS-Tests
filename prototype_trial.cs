
using System;

class Program
{
    static void Main()
    {
        double radius, height;

        Console.Write("Enter the radius of the cylinder: ");
        radius = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the cylinder: ");
        height = double.Parse(Console.ReadLine());

        double volume = Math.PI * Math.Pow(radius, 2) * height;

        Console.WriteLine($"The volume of the cylinder is: {volume}");
    }
}
