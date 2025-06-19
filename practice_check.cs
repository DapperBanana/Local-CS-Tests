
using System;

namespace QuadraticEquationRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values of coefficients a, b, and c for the equation ax^2 + bx + c = 0:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;
            double sqrtDiscriminant = Math.Sqrt(Math.Abs(discriminant));

            if (discriminant > 0)
            {
                double root1 = (-b + sqrtDiscriminant) / (2 * a);
                double root2 = (-b - sqrtDiscriminant) / (2 * a);
                Console.WriteLine("Root 1: " + root1);
                Console.WriteLine("Root 2: " + root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("Root: " + root);
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = sqrtDiscriminant / (2 * a);
                Console.WriteLine("Root 1: " + realPart + " + " + imaginaryPart + "i");
                Console.WriteLine("Root 2: " + realPart + " - " + imaginaryPart + "i");
            }
        }
    }
}
