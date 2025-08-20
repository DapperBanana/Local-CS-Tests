
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize data
        Dictionary<string, int> data = new Dictionary<string, int>();
        data.Add("Apple", 10);
        data.Add("Banana", 20);
        data.Add("Orange", 15);
        data.Add("Grapes", 25);

        // Generate bar chart
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
