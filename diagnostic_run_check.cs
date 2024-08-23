
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "Apples", 10 },
            { "Oranges", 5 },
            { "Bananas", 8 },
            { "Grapes", 3 }
        };

        int maxValue = 0;
        foreach (int value in data.Values)
        {
            if (value > maxValue)
            {
                maxValue = value;
            }
        }

        foreach (string key in data.Keys)
        {
            Console.Write(key + " | ");
            for (int i = 0; i < data[key]; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Legend:");
        for (int i = 1; i <= maxValue; i++)
        {
            Console.WriteLine(i + " = " + new string('#', i));
        }
    }
}
