
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "A", 10 },
            { "B", 20 },
            { "C", 30 },
            { "D", 5 },
            { "E", 15 }
        };

        // Find maximum value
        int maxValue = dictionary.Values.Max();

        // Find minimum value
        int minValue = dictionary.Values.Min();

        Console.WriteLine($"Maximum value: {maxValue}");
        Console.WriteLine($"Minimum value: {minValue}");
    }
}
