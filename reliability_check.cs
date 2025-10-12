
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, depth, area;

        Console.Write("Enter the length of the first base: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the second base: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the trapezoid: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the depth of the prism: ");
        depth = Convert.ToDouble(Console.ReadLine());

        area = ((base1 + base2) / 2) * height * depth;

        Console.WriteLine("The area of the trapezoidal prism is: " + area);
        
        Console.ReadLine();
    }
}
