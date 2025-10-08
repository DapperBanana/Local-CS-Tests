
using System;

class Program
{
    static void Main()
    {
        double r1, r2, h;

        Console.WriteLine("Enter the value of radius of the top base (r1) of the frustum: ");
        r1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of radius of the bottom base (r2) of the frustum: ");
        r2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of height (h) of the frustum: ");
        h = Convert.ToDouble(Console.ReadLine());

        double l = Math.Sqrt((h * h) + Math.Pow((r1 - r2), 2));
        double area = Math.PI * (r1 + r2) * l + Math.PI * Math.Pow(r1, 2) + Math.PI * Math.Pow(r2, 2);

        Console.WriteLine("The area of the frustum of the cone is: " + area);
    }
}
