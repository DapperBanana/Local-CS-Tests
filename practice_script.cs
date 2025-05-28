
using System;

namespace TrapezoidalPrismAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input variables for the trapezoidal prism
            double base1, base2, height, length;

            // Prompt user for input values
            Console.WriteLine("Enter the length of the trapezoidal prism:");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of base1 of the trapezoid:");
            base1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of base2 of the trapezoid:");
            base2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the trapezoid:");
            height = Convert.ToDouble(Console.ReadLine());

            // Calculate the area of the trapezoidal prism
            double area = ((base1 + base2) / 2) * height * length;

            // Display the calculated area
            Console.WriteLine("The area of the trapezoidal prism is: " + area);
        }
    }
}
