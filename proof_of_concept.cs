
using System;

class Program
{
    static void Main()
    {
        // Prompt user for input
        Console.WriteLine("Enter the radius of the top of the frustum:");
        double radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the base of the frustum:");
        double radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the slant height of the frustum:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the frustum
        double area = Math.PI * (radius1 + radius2) * (radius1 + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2)));

        // Display the area of the frustum
        Console.WriteLine("The area of the frustum of the cone is: " + area);
    }
}
