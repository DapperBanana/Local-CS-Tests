
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 5, 4, 3, 2, 1 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);
        Console.WriteLine("Correlation Coefficient: " + correlationCoefficient);
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0, sumY2 = 0;

        for (int i = 0; i < list1.Count; i++)
        {
            sumX += list1[i];
            sumY += list2[i];
            sumXY += list1[i] * list2[i];
            sumX2 += list1[i] * list1[i];
            sumY2 += list2[i] * list2[i];
        }

        double n = list1.Count;
        double correlationCoefficient = (n * sumXY - sumX * sumY) / Math.Sqrt((n * sumX2 - sumX * sumX) * (n * sumY2 - sumY * sumY));

        return correlationCoefficient;
    }
}
