
using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c;
        double root1, root2;

        Console.WriteLine("Enter the coefficients of the quadratic equation (a, b, c):");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        
        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("Root 1 = {0}", root1);
            Console.WriteLine("Root 2 = {0}", root2);
        }
        else if (discriminant == 0)
        {
            root1 = -b / (2 * a);
            
            Console.WriteLine("Both roots are equal.");
            Console.WriteLine("Root = {0}", root1);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

            Console.WriteLine("Roots are complex and imaginary.");
            Console.WriteLine("Root 1 = {0} + {1}i", realPart, imaginaryPart);
            Console.WriteLine("Root 2 = {0} - {1}i", realPart, imaginaryPart);
        }
    }
}
