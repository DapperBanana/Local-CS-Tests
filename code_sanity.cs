
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary
        Dictionary<string, int> myDict = new Dictionary<string, int>
        {
            {"Apple", 100},
            {"Banana", 50},
            {"Cherry", 75},
            {"Orange", 200}
        };

        // Find the maximum value
        int maxValue = int.MinValue;
        string maxKey = "";
        foreach (var pair in myDict)
        {
            if (pair.Value > maxValue)
            {
                maxValue = pair.Value;
                maxKey = pair.Key;
            }
        }

        // Find the minimum value
        int minValue = int.MaxValue;
        string minKey = "";
        foreach (var pair in myDict)
        {
            if (pair.Value < minValue)
            {
                minValue = pair.Value;
                minKey = pair.Key;
            }
        }

        // Display the results
        Console.WriteLine($"Maximum value: {maxValue} (Key: {maxKey})");
        Console.WriteLine($"Minimum value: {minValue} (Key: {minKey})");
    }
}

