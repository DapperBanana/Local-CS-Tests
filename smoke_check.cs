using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first base of the trapezoid:");
        double base1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the second base of the trapezoid:");
        double base2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid:");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = ((base1 + base2) / 2) * height;

        Console.WriteLine($"The area of the trapezoid is: {area}");
    }
}