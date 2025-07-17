
using System;

class QuadraticEquationRoots
{
    static void Main()
    {
        double a, b, c;

        Console.WriteLine("Enter the coefficients of the quadratic equation:");
        
        Console.Write("a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("c: ");
        c = Convert.ToDouble(Console.ReadLine());

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
            Console.WriteLine("No real roots exist.");
        }
    }
}
