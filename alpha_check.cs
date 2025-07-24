
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 7, 3, 8, 1, 6, 4 };
        numbers.Sort();

        double median;
        if (numbers.Count % 2 == 0)
        {
            median = (numbers[numbers.Count / 2 - 1] + numbers[numbers.Count / 2]) / 2.0;
        }
        else
        {
            median = numbers[numbers.Count / 2];
        }

        Console.WriteLine("List of numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Median: " + median);
    }
}
