
using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c, discriminant, root1, root2;

        Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");
        Console.Write("a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: ");
        c = Convert.ToDouble(Console.ReadLine());

        discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Root 1 = " + root1);
            Console.WriteLine("Root 2 = " + root2);
        }
        else if (discriminant == 0)
        {
            root1 = -b / (2 * a);
            Console.WriteLine("Root 1 = Root 2 = " + root1);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("Root 1 = " + realPart + "+" + imaginaryPart + "i");
            Console.WriteLine("Root 2 = " + realPart + "-" + imaginaryPart + "i");
        }
    }
}
