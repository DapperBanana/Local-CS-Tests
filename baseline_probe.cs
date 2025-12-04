using System;
using System.Collections.Generic;
using System.Linq;

public class CorrelationCoefficientCalculator
{
    public static void Main()
    {
        var list1 = new List<double> { 1, 2, 3, 4, 5 };
        var list2 = new List<double> { 2, 4, 6, 8, 10 };

        double correlation = CalculateCorrelationCoefficient(list1, list2);
        Console.WriteLine($"Correlation Coefficient: {correlation}");
    }

    public static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        if (list1 == null || list2 == null || list1.Count != list2.Count || list1.Count == 0)
            throw new ArgumentException("Lists must be non-null, of equal length, and not empty.");

        int n = list1.Count;
        double mean1 = list1.Average();
        double mean2 = list2.Average();

        double sumProductDeviations = 0;
        double sumSquaredDeviations1 = 0;
        double sumSquaredDeviations2 = 0;

        for (int i = 0; i < n; i++)
        {
            double deviation1 = list1[i] - mean1;
            double deviation2 = list2[i] - mean2;

            sumProductDeviations += deviation1 * deviation2;
            sumSquaredDeviations1 += deviation1 * deviation1;
            sumSquaredDeviations2 += deviation2 * deviation2;
        }

        double denominator = Math.Sqrt(sumSquaredDeviations1) * Math.Sqrt(sumSquaredDeviations2);
        if (denominator == 0)
            throw new InvalidOperationException("Standard deviation is zero, correlation is undefined.");

        return sumProductDeviations / denominator;
    }
}