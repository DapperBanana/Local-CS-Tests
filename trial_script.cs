
using System;

class Program
{
    static void Main()
    {
        // Getting user input for the dimensions of the trapezoidal prism
        Console.Write("Enter the length of the top base of the trapezoid: ");
        double topBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the bottom base of the trapezoid: ");
        double bottomBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the trapezoid: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the prism: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculating the area of the trapezoid
        double area = ((topBase + bottomBase) / 2) * height;

        // Calculating the area of the trapezoidal prism
        double totalArea = (2 * area) + (length * (topBase + bottomBase));

        // Displaying the result
        Console.WriteLine($"The area of the trapezoidal prism is: {totalArea}");
    }
}
