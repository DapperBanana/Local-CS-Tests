
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 6, 7, 8, 9, 10 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);
        
        Console.WriteLine($"Correlation coefficient between list1 and list2: {correlationCoefficient}");
    }

    static double CalculateMean(List<double> values)
    {
        double sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }

        return sum / values.Count;
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        if (list1.Count != list2.Count)
        {
            throw new ArgumentException("Lists must have the same length");
        }

        double mean1 = CalculateMean(list1);
        double mean2 = CalculateMean(list2);

        double sum = 0;
        double sumXSquared = 0;
        double sumYSquared = 0;

        for (int i = 0; i < list1.Count; i++)
        {
            double diff1 = list1[i] - mean1;
            double diff2 = list2[i] - mean2;
            sum += diff1 * diff2;
            sumXSquared += diff1 * diff1;
            sumYSquared += diff2 * diff2;
        }

        double correlationCoefficient = sum / Math.Sqrt(sumXSquared * sumYSquared);

        return correlationCoefficient;
    }
}
