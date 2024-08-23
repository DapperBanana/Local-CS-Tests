
using System;

class FrustumOfConeCalculator
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
        
        double slantHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2));
        
        double baseArea = Math.PI * Math.Pow(radius1, 2);
        double topArea = Math.PI * Math.Pow(radius2, 2);
        double lateralArea = Math.PI * (radius1 + radius2) * slantHeight;
        
        double surfaceArea = baseArea + topArea + lateralArea;
        
        Console.WriteLine("The surface area of the frustum of a cone is: " + surfaceArea);
    }
}
