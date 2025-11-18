
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define two sets
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6, 7 };

        // Find the union of the two sets
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);

        // Print the union set
        Console.Write("Union of set1 and set2: ");
        foreach (int num in union)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }
}
