
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>
        {
            {1, 10},
            {2, 5},
            {3, 15},
            {4, 3},
            {5, 20}
        };

        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        foreach (var pair in numbers)
        {
            if (pair.Value > maxValue)
            {
                maxValue = pair.Value;
            }

            if (pair.Value < minValue)
            {
                minValue = pair.Value;
            }
        }

        Console.WriteLine($"Maximum value: {maxValue}");
        Console.WriteLine($"Minimum value: {minValue}");
    }
}
