
using System;

class Program
{
    static void Main()
    {
        double radius, height, volume;

        // Get input from the user for radius and height
        Console.WriteLine("Enter the radius of the cone: ");
        radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the cone: ");
        height = double.Parse(Console.ReadLine());

        // Calculate volume of the cone
        volume = Math.PI * Math.Pow(radius, 2) * (height / 3);

        // Print the volume of the cone
        Console.WriteLine("The volume of the cone is: " + volume);
    }
}
