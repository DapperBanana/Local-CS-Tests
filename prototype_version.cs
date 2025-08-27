
using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the first point:");
            Console.Write("X1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Z1: ");
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point:");
            Console.Write("X2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("Z2: ");
            double z2 = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine($"The distance between the two points is: {distance}");
        }
    }
}
