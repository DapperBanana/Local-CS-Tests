
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("A", 10);
        dict.Add("B", 20);
        dict.Add("C", 5);
        dict.Add("D", 15);

        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        foreach (var kvp in dict)
        {
            if (kvp.Value > maxValue)
            {
                maxValue = kvp.Value;
            }

            if (kvp.Value < minValue)
            {
                minValue = kvp.Value;
            }
        }

        Console.WriteLine("Maximum value in dictionary: " + maxValue);
        Console.WriteLine("Minimum value in dictionary: " + minValue);
    }
}
