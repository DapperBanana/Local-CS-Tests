
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            {"A", 10},
            {"B", 20},
            {"C", 5},
            {"D", 15}
        };

        int max = dictionary.Values.Max();
        int min = dictionary.Values.Min();

        Console.WriteLine("Maximum value in the dictionary is: " + max);
        Console.WriteLine("Minimum value in the dictionary is: " + min);
    }
}
