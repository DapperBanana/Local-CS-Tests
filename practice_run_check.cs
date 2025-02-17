
using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the radius of the cylinder
        Console.Write("Enter the radius of the cylinder: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the height of the cylinder
        Console.Write("Enter the height of the cylinder: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the volume of the cylinder
        double volume = Math.PI * Math.Pow(radius, 2) * height;

        // Display the volume of the cylinder
        Console.WriteLine($"The volume of the cylinder is: {volume}");
    }
}
