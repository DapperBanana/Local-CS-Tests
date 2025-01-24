
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 4, 6, 8, 10 };

        double correlation = CalculateCorrelationCoefficient(list1, list2);

        Console.WriteLine("Correlation Coefficient: " + correlation);
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        if (list1.Count != list2.Count)
        {
            throw new ArgumentException("Both lists must have the same number of elements");
        }

        double mean1 = Mean(list1);
        double mean2 = Mean(list2);

        double numerator = 0;
        double denominator1 = 0;
        double denominator2 = 0;

        for (int i = 0; i < list1.Count; i++)
        {
            numerator += (list1[i] - mean1) * (list2[i] - mean2);
            denominator1 += Math.Pow(list1[i] - mean1, 2);
            denominator2 += Math.Pow(list2[i] - mean2, 2);
        }

        double correlation = numerator / (Math.Sqrt(denominator1) * Math.Sqrt(denominator2));

        return correlation;
    }

    static double Mean(List<double> list)
    {
        double sum = 0;

        foreach (double num in list)
        {
            sum += num;
        }

        return sum / list.Count;
    }
}
