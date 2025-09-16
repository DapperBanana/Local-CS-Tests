
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, prismHeight;

        Console.WriteLine("Enter the length of the top base: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the bottom base: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism: ");
        prismHeight = Convert.ToDouble(Console.ReadLine());

        double area = ((base1 + base2) / 2) * height;
        double volume = area * prismHeight;

        Console.WriteLine("The area of the trapezoidal prism is: " + area);
        Console.WriteLine("The volume of the trapezoidal prism is: " + volume);

        Console.ReadLine();
    }
}
