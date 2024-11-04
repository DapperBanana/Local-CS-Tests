
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.WriteLine("Enter the radius of the base of the frustum: ");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the top of the frustum: ");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum: ");
        height = Convert.ToDouble(Console.ReadLine());

        double slantHeight = Math.Sqrt((height * height) + Math.Pow((radius1 - radius2), 2));
        
        double baseArea1 = Math.PI * radius1 * radius1;
        double baseArea2 = Math.PI * radius2 * radius2;
        
        double lateralSurfaceArea = Math.PI * slantHeight * (radius1 + radius2);
        double totalSurfaceArea = baseArea1 + baseArea2 + lateralSurfaceArea;

        Console.WriteLine("The total surface area of the frustum of a cone is: {0}", totalSurfaceArea);
    }
}
