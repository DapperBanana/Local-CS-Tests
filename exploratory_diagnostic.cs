
using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of point 1:");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("z1 = ");
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the coordinates of point 2:");
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("z2 = ");
            double z2 = double.Parse(Console.ReadLine());

            double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);

            Console.WriteLine($"\nThe distance between the two points in 3D space is: {distance:F2}");
        }

        static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dz = z2 - z1;

            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }
}
