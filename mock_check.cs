
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 3, 4, 5, 6 };

        double correlation = CalculateCorrelation(list1, list2);

        Console.WriteLine($"Correlation coefficient: {correlation}");
    }

    static double CalculateCorrelation(List<double> list1, List<double> list2)
    {
        if (list1.Count != list2.Count)
            throw new ArgumentException("Lists must have the same length");

        double sumX = 0;
        double sumY = 0;
        double sumXY = 0;
        double sumX2 = 0;
        double sumY2 = 0;

        for (int i = 0; i < list1.Count; i++)
        {
            sumX += list1[i];
            sumY += list2[i];
            sumXY += list1[i] * list2[i];
            sumX2 += list1[i] * list1[i];
            sumY2 += list2[i] * list2[i];
        }

        double n = list1.Count;
        double correlation = (n * sumXY - sumX * sumY) / Math.Sqrt((n * sumX2 - sumX * sumX) * (n * sumY2 - sumY * sumY));

        return correlation;
    }
}
