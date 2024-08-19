
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 4, 6, 8, 10 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);

        Console.WriteLine("Correlation Coefficient: " + correlationCoefficient);
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        double sumX = 0;
        double sumY = 0;
        double sumXY = 0;
        double sumXSquare = 0;
        double sumYSquare = 0;

        int n = list1.Count;

        for (int i = 0; i < n; i++)
        {
            sumX += list1[i];
            sumY += list2[i];
            sumXY += list1[i] * list2[i];
            sumXSquare += list1[i] * list1[i];
            sumYSquare += list2[i] * list2[i];
        }

        double correlationCoefficient = (n * sumXY - sumX * sumY) / Math.Sqrt((n * sumXSquare - sumX * sumX) * (n * sumYSquare - sumY * sumY));

        return correlationCoefficient;
    }
}
