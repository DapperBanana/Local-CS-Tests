
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
            {"D", 15},
            {"E", 30}
        };

        int minValue = int.MaxValue;
        int maxValue = int.MinValue;

        foreach (var pair in dict)
        {
            if (pair.Value < minValue)
            {
                minValue = pair.Value;
            }

            if (pair.Value > maxValue)
            {
                maxValue = pair.Value;
            }
        }

        Console.WriteLine("Minimum value: " + minValue);
        Console.WriteLine("Maximum value: " + maxValue);
    }
}
