
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>()
        {
            { "A", 10 },
            { "B", 20 },
            { "C", 15 },
            { "D", 25 }
        };

        foreach (var item in data)
        {
            Console.Write(item.Key + " | ");
            for (int i = 0; i < item.Value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
