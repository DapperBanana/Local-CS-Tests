using System;

class Program
{
    static void Main()
    {
        // Prompt for the lengths of the two bases of the trapezoid
        Console.Write("Enter the length of the first base (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the second base (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Prompt for the height of the trapezoid
        Console.Write("Enter the height of the trapezoid (h): ");
        double h = Convert.ToDouble(Console.ReadLine());

        // Prompt for the length of the prism
        Console.Write("Enter the length of the prism (l): ");
        double l = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the trapezoidal base
        double baseArea = 0.5 * (a + b) * h;

        // Calculate the volume of the prism
        double volume = baseArea * l;

        Console.WriteLine($"The volume of the trapezoidal prism is: {volume}");
    }
}