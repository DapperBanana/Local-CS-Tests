
using System;

class Program
{
    static void Main()
    {
        double r1, r2, h;

        Console.WriteLine("Enter the radius of the base of the frustum: ");
        r1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the radius of the top of the frustum: ");
        r2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum: ");
        h = double.Parse(Console.ReadLine());

        double l = Math.Sqrt(h * h + (r1 - r2) * (r1 - r2));
        double area = Math.PI * (r1 + r2) * (l + r1 + r2);

        Console.WriteLine("The area of the frustum of the cone is: " + area);
    }
}
