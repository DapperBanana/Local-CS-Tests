
using System;

class FrustumOfConeAreaCalculator
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.Write("Enter the radius of the top base of the frustum of a cone: ");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the radius of the bottom base of the frustum of a cone: ");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the frustum of a cone: ");
        height = Convert.ToDouble(Console.ReadLine());

        double slantHeight = Math.Sqrt((radius1 - radius2) * (radius1 - radius2) + height * height);
        
        double lateralSurfaceArea = Math.PI * (radius1 + radius2) * slantHeight;

        double topBaseArea = Math.PI * radius1 * radius1;
        double bottomBaseArea = Math.PI * radius2 * radius2;

        double totalSurfaceArea = topBaseArea + bottomBaseArea + lateralSurfaceArea;

        Console.WriteLine("The total surface area of the frustum of a cone is: " + totalSurfaceArea);
    }
}
