
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary of data
        Dictionary<string, int> data = new Dictionary<string, int>();
        data.Add("Apple", 5);
        data.Add("Orange", 8);
        data.Add("Banana", 3);
        data.Add("Grapes", 6);

        // Find maximum value for scaling
        int maxValue = 0;
        foreach (var value in data.Values)
        {
            if (value > maxValue)
                maxValue = value;
        }

        // Display bar chart
        foreach (var item in data)
        {
            Console.Write(item.Key + " |");
            for (int i = 0; i < (item.Value * 10 / maxValue); i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
