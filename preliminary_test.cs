
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var set1 = new HashSet<int> { 1, 2, 3, 4 };
        var set2 = new HashSet<int> { 3, 4, 5, 6 };

        var union = new HashSet<int>(set1);
        union.UnionWith(set2);

        Console.WriteLine("Union of set1 and set2:");
        foreach (var num in union)
        {
            Console.WriteLine(num);
        }
    }
}
