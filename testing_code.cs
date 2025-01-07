
using System;

class Program
{
    static void Main()
    {
        double r1, r2, l, area;
        
        Console.WriteLine("Enter the radius of the top base of the frustum: ");
        r1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the radius of the bottom base of the frustum: ");
        r2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the slant height of the frustum: ");
        l = double.Parse(Console.ReadLine());
        
        area = Math.PI * (r1 + r2) * l;
        
        Console.WriteLine("The area of the frustum of the cone is: " + area);
    }
}
