
using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, z1, x2, y2, z2;
            Console.WriteLine("Enter the coordinates of the first point (x, y, z):");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (x, y, z):");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            z2 = Convert.ToDouble(Console.ReadLine());

            double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);

            Console.WriteLine("The distance between the two points is: " + distance);
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
