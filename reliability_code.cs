
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height, slantHeight, area;

        Console.WriteLine("Enter the radius of the larger base of the frustum: ");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the smaller base of the frustum: ");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum: ");
        height = Convert.ToDouble(Console.ReadLine());

        slantHeight = Math.Sqrt(Math.Pow((radius1 - radius2), 2) + Math.Pow(height, 2));

        area = Math.PI * (radius1 + radius2) * slantHeight + Math.PI * Math.Pow(radius1, 2) + Math.PI * Math.Pow(radius2, 2);

        Console.WriteLine("The area of the frustum of a cone is: " + area);
    }
}
