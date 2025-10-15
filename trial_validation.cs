
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
            {"D", 15}
        };

        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        foreach (var item in dictionary)
        {
            if (item.Value > maxValue)
            {
                maxValue = item.Value;
            }

            if (item.Value < minValue)
            {
                minValue = item.Value;
            }
        }

        Console.WriteLine("Maximum value in dictionary: " + maxValue);
        Console.WriteLine("Minimum value in dictionary: " + minValue);
    }
}
