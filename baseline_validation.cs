
using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2, side3;

            Console.WriteLine("Enter the length of side 1: ");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of side 2: ");
            side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of side 3: ");
            side3 = Convert.ToDouble(Console.ReadLine());

            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}
