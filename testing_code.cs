
using System;

class Program
{
    static void Main()
    {
        double s, h, area;
        
        Console.WriteLine("Enter the side length of the pentagon (s):");
        s = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the prism (h):");
        h = Convert.ToDouble(Console.ReadLine());
        
        double apothem = s / (2 * Math.Tan(Math.PI / 5));
        double perimeter = 5 * s;
        
        double baseArea = 0.5 * perimeter * apothem;
        double lateralArea = perimeter * h;
        
        area = 2 * baseArea + lateralArea;
        
        Console.WriteLine("The area of the regular pentagonal prism is: " + area);
    }
}
