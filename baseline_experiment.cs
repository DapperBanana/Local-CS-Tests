
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 4, 6, 8, 10 };

        double correlation = CalculateCorrelation(list1, list2);

        Console.WriteLine($"Correlation coefficient: {correlation}");
    }

    static double CalculateCorrelation(List<double> list1, List<double> list2)
    {
        if (list1.Count != list2.Count)
        {
            throw new ArgumentException("Lists must have the same number of elements");
        }

        double sum1 = list1.Sum();
        double sum2 = list2.Sum();

        double mean1 = sum1 / list1.Count;
        double mean2 = sum2 / list2.Count;

        double squaredSum1 = list1.Sum(x => Math.Pow(x, 2));
        double squaredSum2 = list2.Sum(x => Math.Pow(x, 2));

        double productSum = 0;
        for (int i = 0; i < list1.Count; i++)
        {
            productSum += list1[i] * list2[i];
        }

        double correlation = (list1.Count * productSum - sum1 * sum2) /
                            Math.Sqrt((list1.Count * squaredSum1 - Math.Pow(sum1, 2)) *
                                      (list1.Count * squaredSum2 - Math.Pow(sum2, 2)));

        return correlation;
    }
}
