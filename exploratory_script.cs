
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, length;
        
        Console.WriteLine("Enter the length of the trapezoidal prism: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of base 1 of the trapezoid: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of base 2 of the trapezoid: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid: ");
        height = Convert.ToDouble(Console.ReadLine());

        double area = (base1 + base2) / 2 * height * length;
        Console.WriteLine($"The area of the trapezoidal prism is: {area}");
    }
}
