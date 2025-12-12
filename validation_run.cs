using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample dictionary
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"a", 10},
            {"b", 5},
            {"c", 20},
            {"d", 15}
        };

        // Find maximum value
        int maxValue = dict.Values.Max();

        // Find minimum value
        int minValue = dict.Values.Min();

        Console.WriteLine($"Maximum value: {maxValue}");
        Console.WriteLine($"Minimum value: {minValue}");
    }
}