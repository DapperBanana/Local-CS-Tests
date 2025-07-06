
using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c;
        double discriminant, sqrt_discriminant, root1, root2;

        Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");
        Console.Write("Enter a:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b:");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c:");
        c = Convert.ToDouble(Console.ReadLine());

        discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            sqrt_discriminant = Math.Sqrt(discriminant);
            root1 = (-b + sqrt_discriminant) / (2 * a);
            root2 = (-b - sqrt_discriminant) / (2 * a);

            Console.WriteLine("Root1 = {0}", root1);
            Console.WriteLine("Root2 = {0}", root2);
        }
        else if (discriminant == 0)
        {
            root1 = -b / (2 * a);
            Console.WriteLine("Root1 = Root2 = {0}", root1);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("Root1 = {0} + {1}i", realPart, imaginaryPart);
            Console.WriteLine("Root2 = {0} - {1}i", realPart, imaginaryPart);
        }
    }
}
