
using System;
using System.Collections.Generic;

class BarChartGenerator
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            {"Apple", 5},
            {"Orange", 8},
            {"Banana", 3},
            {"Grapes", 6},
            {"Mango", 10}
        };

        foreach (var item in data)
        {
            Console.Write($"{item.Key}: ");
            for (int i = 0; i < item.Value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
