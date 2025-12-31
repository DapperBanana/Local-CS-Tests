using System;

class QuadraticEquationSolver
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coefficient b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coefficient c:");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (a == 0)
        {
            if (b != 0)
            {
                double root = -c / b;
                Console.WriteLine($"Linear equation root: {root}");
            }
            else
            {
                Console.WriteLine("Invalid equation. Coefficients a and b cannot both be zero.");
            }
        }
        else
        {
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Roots are real and different: {root1} and {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Roots are real and same: {root}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"Roots are complex: {realPart} + {imaginaryPart}i and {realPart} - {imaginaryPart}i");
            }
        }
    }
}