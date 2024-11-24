
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>()
        {
            {"A", 20},
            {"B", 35},
            {"C", 15},
            {"D", 40},
            {"E", 10}
        };

        foreach (var item in data)
        {
            Console.WriteLine($"{item.Key}: {new string('#', item.Value)}");
        }
    }
}
