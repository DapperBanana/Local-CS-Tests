
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");

        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("Root 1: {0}", root1);
            Console.WriteLine("Root 2: {0}", root2);
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);

            Console.WriteLine("Root: {0}", root);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

            Console.WriteLine("Root 1: {0} + {1}i", realPart, imaginaryPart);
            Console.WriteLine("Root 2: {0} - {1}i", realPart, imaginaryPart);
        }
    }
}
