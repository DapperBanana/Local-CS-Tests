
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, length, area;

        Console.WriteLine("Enter the value of base1: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of base2: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of height: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of length: ");
        length = Convert.ToDouble(Console.ReadLine());

        area = ((base1 + base2) / 2) * height * length;

        Console.WriteLine($"The area of the trapezoidal prism is: {area}");
    }
}
