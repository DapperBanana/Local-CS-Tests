using System;

class Program
{
    static void Main()
    {
        // Prompt the user for the radius
        Console.Write("Enter the radius of the cone: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the height
        Console.Write("Enter the height of the cone: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the volume of the cone
        double volume = (Math.PI * Math.Pow(radius, 2) * height) / 3;

        // Output the result
        Console.WriteLine($"The volume of the cone is: {volume}");
    }
}