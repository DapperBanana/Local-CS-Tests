
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.WriteLine("Enter the radius of the base of the cone: ");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the top of the cone: ");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the cone: ");
        height = Convert.ToDouble(Console.ReadLine());

        double slantHeight = Math.Sqrt(Math.Pow((radius1 - radius2), 2) + Math.Pow(height, 2));

        double lateralArea = Math.PI * (radius1 + radius2) * slantHeight;

        double baseArea = Math.PI * Math.Pow(radius1, 2);
        double topArea = Math.PI * Math.Pow(radius2, 2);

        double frustumArea = baseArea + topArea + lateralArea;

        Console.WriteLine("The area of the frustum of the cone is: " + frustumArea);
    }
}
