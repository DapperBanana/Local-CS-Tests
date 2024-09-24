
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5, 6 };
        List<double> list2 = new List<double> { 2, 4, 6, 8, 10, 12 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);

        Console.WriteLine("Correlation Coefficient: " + correlationCoefficient);
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        double sumXY = 0;
        double sumX = 0;
        double sumY = 0;
        double sumX2 = 0;
        double sumY2 = 0;
        int n = list1.Count;

        for (int i = 0; i < n; i++)
        {
            sumXY += list1[i] * list2[i];
            sumX += list1[i];
            sumY += list2[i];
            sumX2 += Math.Pow(list1[i], 2);
            sumY2 += Math.Pow(list2[i], 2);
        }

        double numerator = (n * sumXY) - (sumX * sumY);
        double denominator = Math.Sqrt((n * sumX2 - Math.Pow(sumX, 2)) * (n * sumY2 - Math.Pow(sumY, 2));

        return numerator / denominator;
    }
}
