using System;

class Program
{
    static void Main()
    {
        // Input the lengths of the two bases and the height
        Console.Write("Enter the length of the first base: ");
        double base1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the second base: ");
        double base2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the trapezoid: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area
        double area = ((base1 + base2) / 2) * height;

        // Output the result
        Console.WriteLine($"The area of the trapezoid is: {area}");
    }
}