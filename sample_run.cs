
using System;

class Program
{
    static void Main()
    {
        // Define the dimensions of the trapezoidal prism
        double base1, base2, height, prismHeight;

        // Get user input for the dimensions
        Console.Write("Enter the length of the first base of the trapezoid: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the second base of the trapezoid: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the trapezoid: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the prism: ");
        prismHeight = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the trapezoid
        double area = 0.5 * (base1 + base2) * height;

        // Calculate the total surface area of the trapezoidal prism
        double totalArea = 2 * area + (base1 + base2) * prismHeight;

        Console.WriteLine($"The area of the trapezoidal prism is: {totalArea}");
    }
}
