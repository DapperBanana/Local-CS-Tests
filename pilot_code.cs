
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.WriteLine("Enter the radius of the top base of the frustum: ");
        radius1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the radius of the bottom base of the frustum: ");
        radius2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the frustum: ");
        height = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * (radius1 * radius1 + radius1 * radius2 + radius2 * radius2) + Math.PI * Math.Sqrt((radius1 - radius2) * (radius1 - radius2) + height * height);

        Console.WriteLine("The area of the frustum of cone is: " + area);
    }
}
