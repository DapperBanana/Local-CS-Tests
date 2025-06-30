
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;
        
        Console.WriteLine("Enter the radius of the base of the frustum: ");
        radius1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the radius of the top of the frustum: ");
        radius2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the frustum: ");
        height = double.Parse(Console.ReadLine());
        
        double slantHeight = Math.Sqrt((radius1 - radius2) * (radius1 - radius2) + height * height);
        
        double surfaceArea = Math.PI * (radius1 + radius2) * slantHeight + Math.PI * (radius1 * radius1 + radius2 * radius2);
        
        Console.WriteLine("The surface area of the frustum of a cone is: " + surfaceArea);
    }
}
