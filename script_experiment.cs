
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            {"A", 5},
            {"B", 3},
            {"C", 7},
            {"D", 2}
        };

        Console.WriteLine("Bar Chart:");

        foreach (var key in data.Keys)
        {
            Console.Write(key + " | ");
            for (int i = 0; i < data[key]; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
