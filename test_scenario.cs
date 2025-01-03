
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the top base of the trapezoid:");
        double topBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the bottom base of the trapezoid:");
        double bottomBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid:");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = ((topBase + bottomBase) / 2) * height;

        Console.WriteLine($"The area of the trapezoid is {area}");
    }
}
