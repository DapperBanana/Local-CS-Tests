
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };

        Console.WriteLine("Set 1: " + string.Join(", ", set1));
        Console.WriteLine("Set 2: " + string.Join(", ", set2));

        // Find the union of the two sets
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);

        Console.WriteLine("Union of Set 1 and Set 2: " + string.Join(", ", unionSet));
    }
}
