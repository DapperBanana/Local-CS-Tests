
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define two sets
        var set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        var set2 = new HashSet<int> { 3, 4, 5, 6, 7 };

        // Find the union of the two sets
        var union = new HashSet<int>(set1);
        union.UnionWith(set2);

        // Print the union
        Console.Write("Union of the two sets: ");
        foreach (int num in union)
        {
            Console.Write(num + " ");
        }
    }
}
