
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int>() { 3, 4, 5, 6, 7 };

        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);

        Console.WriteLine("Union of Set1 and Set2:");
        foreach (int num in unionSet)
        {
            Console.Write(num + " ");
        }
    }
}
