
using System;

namespace TrapezoidalPrismAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1, base2, height, length, area;

            Console.WriteLine("Enter the length of the trapezoidal prism: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of base 1: ");
            base1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of base 2: ");
            base2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the trapezoidal prism: ");
            height = Convert.ToDouble(Console.ReadLine());

            area = 0.5 * (base1 + base2) * height * length;
            Console.WriteLine("The area of the trapezoidal prism is: " + area);
        }
    }
}
