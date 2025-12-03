using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double> { 3, 1, 4, 2, 5 };

        double median = CalculateMedian(numbers);
        Console.WriteLine($"Median: {median}");
    }

    static double CalculateMedian(List<double> numbers)
    {
        var sortedNumbers = numbers.OrderBy(n => n).ToList();
        int count = sortedNumbers.Count;

        if (count == 0)
            throw new InvalidOperationException("Cannot compute median of an empty list.");

        if (count % 2 == 1)
        {
            // Odd number of elements
            return sortedNumbers[count / 2];
        }
        else
        {
            // Even number of elements
            double middle1 = sortedNumbers[(count / 2) - 1];
            double middle2 = sortedNumbers[count / 2];
            return (middle1 + middle2) / 2;
        }
    }
}