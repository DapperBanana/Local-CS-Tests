
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the quadratic equation (a, b, c):");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"The roots of the equation are: {root1} and {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"The root of the equation is: {root}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine($"The roots of the equation are: {realPart} + {imaginaryPart}i and {realPart} - {imaginaryPart}i");
        }
    }
}
