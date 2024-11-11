
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> x = new List<double> { 1, 2, 3, 4, 5 };
        List<double> y = new List<double> { 2, 4, 6, 8, 10 };

        double correlation = CalculateCorrelationCoefficient(x, y);

        Console.WriteLine("Correlation Coefficient: {0}", correlation);
    }

    static double CalculateCorrelationCoefficient(List<double> x, List<double> y)
    {
        double sum_x = 0;
        double sum_y = 0;
        double sum_x2 = 0;
        double sum_y2 = 0;
        double sum_xy = 0;

        int n = x.Count;

        for (int i = 0; i < n; i++)
        {
            sum_x += x[i];
            sum_y += y[i];
            sum_x2 += Math.Pow(x[i], 2);
            sum_y2 += Math.Pow(y[i], 2);
            sum_xy += x[i] * y[i];
        }

        double numerator = n * sum_xy - sum_x * sum_y;
        double denominator = Math.Sqrt((n * sum_x2 - Math.Pow(sum_x, 2)) * (n * sum_y2 - Math.Pow(sum_y, 2));

        double correlation = numerator / denominator;

        return correlation;
    }
}
