
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, length;

        Console.Write("Enter the length of the trapezoidal prism: ");
        length = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the first base of the trapezoidal prism: ");
        base1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second base of the trapezoidal prism: ");
        base2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the trapezoidal prism: ");
        height = double.Parse(Console.ReadLine());

        double area = ((base1 + base2) / 2) * height * length;

        Console.WriteLine($"The area of the trapezoidal prism is: {area}");
    }
}
