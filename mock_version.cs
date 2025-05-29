
using System;

class Program
{
    static void Main()
    {
        // Input variables
        double height, radius1, radius2;

        // Get user input for height, radius1 and radius2
        Console.Write("Enter the height of the frustum: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the radius of the bottom base of the frustum: ");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the radius of the top base of the frustum: ");
        radius2 = Convert.ToDouble(Console.ReadLine());

        // Calculate the slant height of the frustum
        double slantHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow((radius1 - radius2), 2));

        // Calculate the lateral surface area of the frustum
        double lateralArea = Math.PI * (radius1 + radius2) * slantHeight;

        // Calculate the top and bottom base areas of the frustum
        double baseArea1 = Math.PI * Math.Pow(radius1, 2);
        double baseArea2 = Math.PI * Math.Pow(radius2, 2);

        // Calculate the total surface area of the frustum
        double totalArea = baseArea1 + baseArea2 + lateralArea;

        // Output the total area of the frustum
        Console.WriteLine("The total surface area of the frustum is: " + totalArea);
    }
}
