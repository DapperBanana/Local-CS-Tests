
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        // Convert decimal to fraction
        double epsilon = 0.000001;
        int maxIterations = 10000;
        int n = 1;
        double error = double.MaxValue;
        double fraction = 0;
        for (int i = 1; i <= maxIterations; i++)
        {
            double tempFraction = Math.Round(number * i) / i;
            double tempError = Math.Abs(number - tempFraction);
            if (tempError < error)
            {
                error = tempError;
                fraction = tempFraction;
                n = i;
            }
            if (error < epsilon)
            {
                break;
            }
        }

        Console.WriteLine($"Fraction representation of {number}: {fraction}/{n}");
    }
}
