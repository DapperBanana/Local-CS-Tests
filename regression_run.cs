
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary containing data for the bar chart
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "A", 5 },
            { "B", 10 },
            { "C", 8 },
            { "D", 3 }
        };

        // Find the maximum value in the dictionary
        int max = 0;
        foreach (int value in data.Values)
        {
            if (value > max)
            {
                max = value;
            }
        }

        // Draw the bar chart
        foreach (var kvp in data)
        {
            string bar = new string('*', kvp.Value);
            Console.WriteLine($"{kvp.Key}: {bar}");
        }
    }
}
