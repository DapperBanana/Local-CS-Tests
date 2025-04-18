
using System;

class Program
{
    static void Main()
    {
        double a, b, c;
        double x1, x2;

        Console.WriteLine("Enter the coefficients of the quadratic equation (a, b, c):");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Root 1 = {0}, Root 2 = {1}", x1, x2);
        }
        else if (discriminant == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("Root 1 = Root 2 = {0}", x1);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("Root 1 = {0} + {1}i, Root 2 = {0} - {1}i", realPart, imaginaryPart);
        }
    }
}
