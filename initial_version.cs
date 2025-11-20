
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.WriteLine("Enter the radius of the top base of the frustum:");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the bottom base of the frustum:");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum:");
        height = Convert.ToDouble(Console.ReadLine());

        double slantHeight = Math.Sqrt(Math.Pow(radius1 - radius2, 2) + Math.Pow(height, 2));
        double surfaceArea = Math.PI * (radius1 + radius2) * slantHeight + Math.PI * radius1 * radius1 + Math.PI * radius2 * radius2;

        Console.WriteLine("The surface area of the frustum of a cone is: " + surfaceArea);
    }
}
