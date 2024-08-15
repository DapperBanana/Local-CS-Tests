
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the top base length of the trapezoid: ");
        double topBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the bottom base length of the trapezoid: ");
        double bottomBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the trapezoidal prism: ");
        double length = Convert.ToDouble(Console.ReadLine());

        double area = ((topBase + bottomBase) / 2) * height;
        double totalArea = area * length;

        Console.WriteLine("The area of the trapezoidal prism is: {0}", totalArea);
    }
}
