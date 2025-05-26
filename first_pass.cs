
using System;

class PyramidAreaCalculator
{
    static void Main()
    {
        // Input base area and height of pyramid
        Console.WriteLine("Enter the base area of the pyramid: ");
        double baseArea = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the pyramid: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the pyramid
        double pyramidArea = (baseArea + baseArea / 2) * height;

        // Print the area of the pyramid
        Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
    }
}
