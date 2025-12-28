using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double> { 5, 2, 9, 1, 7, 4 };
        double median = FindMedian(numbers);
        Console.WriteLine($"Median: {median}");
    }

    static double FindMedian(List<double> numbers)
    {
        var sortedNumbers = numbers.OrderBy(n => n).ToList();
        int count = sortedNumbers.Count;

        if (count == 0)
            throw new InvalidOperationException("Cannot find median of an empty list.");

        if (count % 2 == 1)
        {
            // Odd number of elements
            return sortedNumbers[count / 2];
        }
        else
        {
            // Even number of elements
            double mid1 = sortedNumbers[(count / 2) - 1];
            double mid2 = sortedNumbers[count / 2];
            return (mid1 + mid2) / 2;
        }
    }
}