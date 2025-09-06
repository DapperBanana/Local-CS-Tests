
using System;

class Program
{
    static void Main()
    {
        double radius, height, volume;
        
        // Taking input from user for radius and height
        Console.Write("Enter the radius of the cylinder: ");
        radius = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the cylinder: ");
        height = Convert.ToDouble(Console.ReadLine());
        
        // Calculating volume of the cylinder
        volume = Math.PI * Math.Pow(radius, 2) * height;
        
        Console.WriteLine($"The volume of the cylinder is: {volume}");
    }
}
