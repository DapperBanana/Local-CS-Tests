
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            {"A", 10},
            {"B", 20},
            {"C", 5},
            {"D", 15},
            {"E", 25}
        };

        int maxValue = int.MinValue;
        string maxKey = "";
        int minValue = int.MaxValue;
        string minKey = "";

        foreach (var entry in dictionary)
        {
            if (entry.Value > maxValue)
            {
                maxValue = entry.Value;
                maxKey = entry.Key;
            }

            if (entry.Value < minValue)
            {
                minValue = entry.Value;
                minKey = entry.Key;
            }
        }

        Console.WriteLine($"Maximum value: {maxValue}, Key: {maxKey}");
        Console.WriteLine($"Minimum value: {minValue}, Key: {minKey}");
    }
}
