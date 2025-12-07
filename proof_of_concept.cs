using System;
using System.Collections.Generic;
using System.Linq;

public class CorrelationCalculator
{
    public static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 4, 5, 4, 5 };

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

        double numerator = 0;
        double denominatorPart1 = 0;
        double denominatorPart2 = 0;

        for (int i = 0; i < n; i++)
        {
            double diff1 = list1[i] - mean1;
            double diff2 = list2[i] - mean2;

            numerator += diff1 * diff2;
            denominatorPart1 += diff1 * diff1;
            denominatorPart2 += diff2 * diff2;
        }

        double denominator = Math.Sqrt(denominatorPart1) * Math.Sqrt(denominatorPart2);

        if (denominator == 0)
            throw new InvalidOperationException("Denominator is zero. Cannot compute correlation.");

        return numerator / denominator;
    }
}