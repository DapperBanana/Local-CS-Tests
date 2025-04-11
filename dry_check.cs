
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            {"A", 5},
            {"B", 10},
            {"C", 7},
            {"D", 3}
        };

        Console.WriteLine("Bar Chart");
        Console.WriteLine("----------------");

        foreach (var kvp in data)
        {
            Console.Write(kvp.Key + " |");
            for (int i = 0; i < kvp.Value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
