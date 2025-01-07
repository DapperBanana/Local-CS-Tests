
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, depth, area;

        Console.WriteLine("Enter the length of base 1: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of base 2: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the depth of the prism: ");
        depth = Convert.ToDouble(Console.ReadLine());

        area = 0.5 * (base1 + base2) * height * depth;
        
        Console.WriteLine("The area of the trapezoidal prism is: " + area);
    }
}
