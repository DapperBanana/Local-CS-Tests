
using System;

class ConeVolumeCalculator
{
    static void Main()
    {
        double radius, height, volume;

        // Get radius and height from user
        Console.WriteLine("Enter the radius of the cone: ");
        radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the cone: ");
        height = Convert.ToDouble(Console.ReadLine());

        // Calculate volume of cone
        volume = Math.PI * Math.Pow(radius, 2) * height / 3;

        // Display the result
        Console.WriteLine("The volume of the cone is: " + volume);
    }
}
