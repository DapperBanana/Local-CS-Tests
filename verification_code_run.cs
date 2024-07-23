
using System;

class Program
{
    static void Main()
    {
        double radius, height, volume;

        // Get user input for radius
        Console.Write("Enter the radius of the cylinder: ");
        radius = Convert.ToDouble(Console.ReadLine());

        // Get user input for height
        Console.Write("Enter the height of the cylinder: ");
        height = Convert.ToDouble(Console.ReadLine());

        // Calculate the volume of the cylinder
        volume = Math.PI * Math.Pow(radius, 2) * height;

        // Print the calculated volume
        Console.WriteLine($"The volume of the cylinder is: {volume}");
    }
}
