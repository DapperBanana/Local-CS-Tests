
using System;

class Program
{
    static void Main()
    {
        double base1, base2, height, area;

        Console.WriteLine("Enter the length of the first base: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the second base: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = 0.5 * (base1 + base2) * height;

        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}
