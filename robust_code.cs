
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>
        {
            {"apple", 10},
            {"banana", 20},
            {"orange", 15},
            {"grapes", 25}
        };

        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        foreach (var pair in myDict)
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

        Console.WriteLine("Maximum value: " + maxValue);
        Console.WriteLine("Minimum value: " + minValue);
    }
}
