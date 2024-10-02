
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, length, area;

        // Get user input for the measurements of the trapezoidal prism
        Console.Write("Enter the length of the trapezoidal prism: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the trapezoidal prism: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of base 1 of the trapezoid: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of base 2 of the trapezoid: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the trapezoidal prism
        area = ((base1 + base2) / 2) * height * length;

        // Print out the area of the trapezoidal prism
        Console.WriteLine("The area of the trapezoidal prism is: " + area);
    }
}
