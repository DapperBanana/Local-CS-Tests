
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("A", 10);
        dict.Add("B", 5);
        dict.Add("C", 20);
        dict.Add("D", 15);

        int maxValue = int.MinValue;
        int minValue = int.MaxValue;
        
        foreach (var pair in dict)
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

        Console.WriteLine("Maximum value in dictionary: " + maxValue);
        Console.WriteLine("Minimum value in dictionary: " + minValue);
    }
}
