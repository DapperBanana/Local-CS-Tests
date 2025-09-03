
using System;

class Program
{
    static void Main()
    {
        double a, b, c;
        Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");

        Console.Write("Enter the value of a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The roots are real and different.");
            Console.WriteLine("Root 1 = {0}", root1);
            Console.WriteLine("Root 2 = {0}", root2);
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("The roots are real and equal.");
            Console.WriteLine("Root 1 = Root 2 = {0}", root);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("The roots are complex and different.");
            Console.WriteLine("Root 1 = {0} + {1}i", realPart, imaginaryPart);
            Console.WriteLine("Root 2 = {0} - {1}i", realPart, imaginaryPart);
        }

        Console.ReadLine();
    }
}
