
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            {"A", 10},
            {"B", 20},
            {"C", 5},
            {"D", 15}
        };

        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        foreach (var pair in dict)
        {
            maxValue = Math.Max(maxValue, pair.Value);
            minValue = Math.Min(minValue, pair.Value);
        }

        Console.WriteLine($"Maximum value: {maxValue}");
        Console.WriteLine($"Minimum value: {minValue}");
    }
}
