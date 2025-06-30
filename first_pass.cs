
using System;

namespace FrustumOfConeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double upperRadius, lowerRadius, height;

            Console.WriteLine("Enter the upper radius of the frustum: ");
            upperRadius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the lower radius of the frustum: ");
            lowerRadius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the frustum: ");
            height = Convert.ToDouble(Console.ReadLine());

            double slantHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(upperRadius - lowerRadius, 2));
            double baseArea = Math.PI * Math.Pow(upperRadius, 2);
            double topArea = Math.PI * Math.Pow(lowerRadius, 2);

            double lateralArea = Math.PI * (upperRadius + lowerRadius) * slantHeight;

            double totalArea = baseArea + topArea + lateralArea;

            Console.WriteLine("The total surface area of the frustum of a cone is: " + totalArea);
        }
    }
}
