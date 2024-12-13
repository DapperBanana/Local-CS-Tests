
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
    List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
    List<double> list2 = new List<double> { 5, 4, 3, 2, 1 };

    double correlation = CalculateCorrelation(list1, list2);

    Console.WriteLine($"Correlation coefficient: {correlation}");
    }

    static double CalculateCorrelation(List<double> list1, List<double> list2)
    {
    if (list1.Count != list2.Count)
    {
        throw new ArgumentException("Lists must have the same length");
    }

    double sumXY = 0;
    double sumX = 0;
    double sumY = 0;
    double sumXSquare = 0;
    double sumYSquare = 0;

    for (int i = 0; i < list1.Count; i++)
    {
        sumXY += list1[i] * list2[i];
        sumX += list1[i];
        sumY += list2[i];
        sumXSquare += Math.Pow(list1[i], 2);
        sumYSquare += Math.Pow(list2[i], 2);
    }

    double n = list1.Count;

    double correlation = (n * sumXY - sumX * sumY) /
                        Math.Sqrt((n * sumXSquare - Math.Pow(sumX, 2)) * (n * sumYSquare - Math.Pow(sumY, 2)));

    return correlation;
    }
}
