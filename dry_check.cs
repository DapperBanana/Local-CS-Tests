
using System;

class Program
{
    static void Main()
    {
        double b1, b2, h, l, area;

        Console.WriteLine("Enter the length of the top base of the trapezoidal prism:");
        b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the bottom base of the trapezoidal prism:");
        b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoidal prism:");
        h = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the trapezoidal prism:");
        l = double.Parse(Console.ReadLine());

        area = ((b1 + b2) / 2) * h + ((b1 + b2) / 2) * l;

        Console.WriteLine("The area of the trapezoidal prism is: " + area);
    }
}
