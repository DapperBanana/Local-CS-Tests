
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, depth, area;

        Console.WriteLine("Enter the length of the top base of the trapezoidal prism:");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the bottom base of the trapezoidal prism:");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoidal prism:");
        height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the depth of the trapezoidal prism:");
        depth = Convert.ToDouble(Console.ReadLine());

        area = ((base1 + base2) / 2) * height * depth;

        Console.WriteLine("The area of the trapezoidal prism is: " + area);
    }
}
