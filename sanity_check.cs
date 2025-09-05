
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>()
        {
            {"A", 5},
            {"B", 10},
            {"C", 15},
            {"D", 20}
        };

        DrawBarChart(data);
    }

    static void DrawBarChart(Dictionary<string, int> data)
    {
        int max = data.Values.Max();

        Console.WriteLine("\n Bar Chart");
        foreach (var item in data)
        {
            Console.Write(item.Key + " |");
            for (int i = 0; i < (double)item.Value / max * 20; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
