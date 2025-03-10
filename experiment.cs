
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 4, 6, 8, 10 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);

        Console.WriteLine($"Correlation Coefficient: {correlationCoefficient}");
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        double mean1 = CalculateMean(list1);
        double mean2 = CalculateMean(list2);

        double numerator = 0;
        double den1 = 0;
        double den2 = 0;

        for (int i = 0; i < list1.Count; i++)
        {
            double diff1 = list1[i] - mean1;
            double diff2 = list2[i] - mean2;

            numerator += diff1 * diff2;
            den1 += Math.Pow(diff1, 2);
            den2 += Math.Pow(diff2, 2);
        }

        double correlationCoefficient = numerator / (Math.Sqrt(den1) * Math.Sqrt(den2));

        return correlationCoefficient;
    }

    static double CalculateMean(List<double> list)
    {
        double sum = 0;

        foreach (double num in list)
        {
            sum += num;
        }

        return sum / list.Count;
    }
}
