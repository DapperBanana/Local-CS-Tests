
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "Apple", 10 },
            { "Orange", 20 },
            { "Banana", 15 },
            { "Grape", 12 }
        };

        Console.WriteLine("Bar Chart:");

        foreach (var item in data)
        {
            Console.Write(item.Key + ": ");
            for (int i = 0; i < item.Value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        Console.ReadLine();
    }
}
