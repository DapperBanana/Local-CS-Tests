using System;

class Program
{
    static void Main()
    {
        // Input the dimensions of the trapezoidal prism
        Console.Write("Enter the length of the prism: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the bottom base of the trapezoid: ");
        double base1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the top base of the trapezoid: ");
        double base2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the trapezoid: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the trapezoid (cross-sectional area)
        double trapezoidArea = ((base1 + base2) / 2.0) * height;

        // Calculate the volume of the trapezoidal prism
        double volume = trapezoidArea * length;

        Console.WriteLine($"The volume of the trapezoidal prism is: {volume}");
    }
}