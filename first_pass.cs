
using System;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args) {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };

        // Create a new HashSet to store the union of set1 and set2
        HashSet<int> unionSet = new HashSet<int>(set1);

        // Add all elements from set2 to the unionSet
        unionSet.UnionWith(set2);

        // Print the unionSet
        Console.Write("Union of set1 and set2: ");
        foreach (int num in unionSet) {
            Console.Write(num + " ");
        }
    }
}
