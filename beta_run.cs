
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.WriteLine("Enter the radius of the larger base of the frustum:");
        radius1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the radius of the smaller base of the frustum:");
        radius2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum:");
        height = double.Parse(Console.ReadLine());

        double area = Math.PI * (radius1 + radius2) * (radius1 * radius2 + radius1 * Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius2 - radius1, 2)) + Math.Pow(height, 2));
        
        Console.WriteLine("The area of the frustum of the cone is: " + area);
    }
}
