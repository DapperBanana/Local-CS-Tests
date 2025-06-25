
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");

        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("Roots are real and different.");
            Console.WriteLine("Root 1: " + root1);
            Console.WriteLine("Root 2: " + root2);
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("Roots are real and same.");
            Console.WriteLine("Root: " + root);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("Roots are complex and different.");
            Console.WriteLine("Root 1: " + realPart + "+" + imaginaryPart + "i");
            Console.WriteLine("Root 2: " + realPart + "-" + imaginaryPart + "i");
        }
    }
}
