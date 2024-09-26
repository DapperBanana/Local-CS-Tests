
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        List<int> numbers = new List<int> { 5, 2, 8, 3, 7 };

        // Sort the list
        numbers.Sort();

        // Find the median
        double median;
        if (numbers.Count % 2 == 0)
        {
            int middleIndex1 = numbers.Count / 2 - 1;
            int middleIndex2 = numbers.Count / 2;
            median = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;
        }
        else
        {
            int middleIndex = numbers.Count / 2;
            median = numbers[middleIndex];
        }

        // Output the median
        Console.WriteLine("Median: " + median);
    }
}
