
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>()
        {
            {"Apples", 10},
            {"Oranges", 15},
            {"Bananas", 8},
            {"Grapes", 12}
        };

        foreach (var pair in data)
        {
            Console.WriteLine("{0}: {1}", pair.Key, new string('*', pair.Value));
        }
    }
}
