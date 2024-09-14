
using System;

namespace QuadraticEquationRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the coefficients of the quadratic equation (a*x^2 + b*x + c = 0):");
            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;
            double root1, root2;

            if (discriminant > 0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Root 1: " + root1 + ", Root 2: " + root2);
            }
            else if (discriminant == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("Root 1 = Root 2: " + root1);
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("Root 1: " + realPart + " + " + imaginaryPart + "i");
                Console.WriteLine("Root 2: " + realPart + " - " + imaginaryPart + "i");
            }
        }
    }
}
