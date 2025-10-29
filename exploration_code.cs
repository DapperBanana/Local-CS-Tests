
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
        List<double> list2 = new List<double> { 2.0, 4.0, 6.0, 8.0, 10.0 };

        Console.WriteLine("Correlation coefficient: " + CalculateCorrelationCoefficient(list1, list2));
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        double sumX = 0;
        double sumY = 0;
        double sumXY = 0;
        double sumX2 = 0;
        double sumY2 = 0;

        int n = list1.Count;

        for (int i = 0; i < n; i++)
        {
            double x = list1[i];
            double y = list2[i];

            sumX += x;
            sumY += y;
            sumXY += x * y;
            sumX2 += x * x;
            sumY2 += y * y;
        }

        double correlation = (n * sumXY - sumX * sumY) / Math.Sqrt((n * sumX2 - sumX * sumX) * (n * sumY2 - sumY * sumY));

        return correlation;
    }
}
