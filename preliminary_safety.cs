
using System;

class AreaCalculator
{
    static void Main()
    {
        double base1, base2, height, depth, area;

        // Input values
        Console.WriteLine("Enter the length of the first base of the trapezoid: ");
        base1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the second base of the trapezoid: ");
        base2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid: ");
        height = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the depth of the prism: ");
        depth = double.Parse(Console.ReadLine());

        // Calculate area of trapezoid
        double trapezoidArea = 0.5 * (base1 + base2) * height;
        
        // Calculate area of trapezoidal prism
        area = trapezoidArea * depth;

        // Output the result
        Console.WriteLine($"The area of the trapezoidal prism is: {area}");
    }
}
