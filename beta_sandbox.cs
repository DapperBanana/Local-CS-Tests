
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };

        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);

        Console.WriteLine("Union of set1 and set2:");
        foreach (int num in unionSet)
        {
            Console.WriteLine(num);
        }
    }
}
