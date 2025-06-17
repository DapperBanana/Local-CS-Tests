
using System;

class CylinderVolumeCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the cylinder: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the cylinder: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(radius, 2) * height;

        Console.WriteLine("The volume of the cylinder is: " + volume);
    }
}
