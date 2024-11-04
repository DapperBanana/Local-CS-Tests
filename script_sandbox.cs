
using System;

namespace FrustumOfConeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double lowerRadius, upperRadius, slantHeight;

            Console.WriteLine("Enter the lower radius of the frustum of cone: ");
            lowerRadius = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper radius of the frustum of cone: ");
            upperRadius = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the slant height of the frustum of cone: ");
            slantHeight = double.Parse(Console.ReadLine());

            double l = Math.Sqrt(Math.Pow(slantHeight, 2) + Math.Pow((upperRadius - lowerRadius), 2));
            double area = Math.PI * (Math.Pow(lowerRadius, 2) + Math.Pow(upperRadius, 2) + lowerRadius * upperRadius + l * (lowerRadius + upperRadius));

            Console.WriteLine($"The area of the frustum of cone is: {area}");
        }
    }
}
