
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;

        // Get input values from the user
        Console.WriteLine("Enter the radius of the top base of the frustum: ");
        radius1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the radius of the bottom base of the frustum: ");
        radius2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum: ");
        height = double.Parse(Console.ReadLine());

        // Calculate the slant height of the frustum
        double slantHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2));

        // Calculate the lateral surface area of the frustum
        double lateralArea = Math.PI * (radius1 + radius2) * slantHeight;

        // Calculate the top base area of the frustum
        double topBaseArea = Math.PI * Math.Pow(radius1, 2);

        // Calculate the bottom base area of the frustum
        double bottomBaseArea = Math.PI * Math.Pow(radius2, 2);

        // Calculate the total surface area of the frustum
        double totalArea = topBaseArea + bottomBaseArea + lateralArea;

        Console.WriteLine("The total surface area of the frustum is: " + totalArea);
    }
}
