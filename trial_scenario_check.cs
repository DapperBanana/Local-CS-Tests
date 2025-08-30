
using System;

class Program
{
    static void Main()
    {
        double height, radius1, radius2;
        
        Console.Write("Enter the height of the frustum: ");
        height = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the radius of the top base of the frustum: ");
        radius1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the radius of the bottom base of the frustum: ");
        radius2 = double.Parse(Console.ReadLine());
        
        double slantHeight = Math.Sqrt(Math.Pow((radius1 - radius2), 2) + Math.Pow(height, 2));
        
        double lateralArea = Math.PI * (radius1 + radius2) * slantHeight;
        
        double topBaseArea = Math.PI * Math.Pow(radius1, 2);
        
        double bottomBaseArea = Math.PI * Math.Pow(radius2, 2);
        
        double area = topBaseArea + bottomBaseArea + lateralArea;
        
        Console.WriteLine("The area of the frustum of the cone is: " + area);
    }
}
