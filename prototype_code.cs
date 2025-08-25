
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 2, 4, 6, 8, 10 };
        List<double> list2 = new List<double> { 1, 3, 5, 7, 9 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);
        Console.WriteLine("Correlation Coefficient: " + correlationCoefficient);
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        double mean1 = CalculateMean(list1);
        double mean2 = CalculateMean(list2);

        double sum = 0;
        double sumSquaredDiff1 = 0;
        double sumSquaredDiff2 = 0;

        for (int i = 0; i < list1.Count; i++)
        {
            double diff1 = list1[i] - mean1;
            double diff2 = list2[i] - mean2;
            sum += diff1 * diff2;

            sumSquaredDiff1 += diff1 * diff1;
            sumSquaredDiff2 += diff2 * diff2;
        }

        double correlationCoefficient = sum / Math.Sqrt(sumSquaredDiff1 * sumSquaredDiff2);
        return correlationCoefficient;
    }

    static double CalculateMean(List<double> list)
    {
        double sum = 0;
        foreach (var value in list)
        {
            sum += value;
        }

        return sum / list.Count;
    }
}
