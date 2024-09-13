
using System;

class TrapezoidalPrismAreaCalculator
{
    static void Main()
    {
        // Input values for the trapezoidal prism
        Console.WriteLine("Enter the top base of the trapezoid:");
        double topBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the bottom base of the trapezoid:");
        double bottomBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid:");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the depth of the prism:");
        double depth = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the trapezoid
        double trapezoidArea = 0.5 * (topBase + bottomBase) * height;

        // Calculate the area of the trapezoidal prism
        double prismArea = 2 * trapezoidArea + (topBase + bottomBase) * depth;

        // Output the result
        Console.WriteLine("The area of the trapezoidal prism is: " + prismArea);
    }
}
