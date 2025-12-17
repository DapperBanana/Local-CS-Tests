using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Example lists
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        // Find intersection
        List<int> intersection = list1.Intersect(list2).ToList();

        // Output the intersection
        Console.WriteLine("Intersection of the two lists:");
        foreach (int item in intersection)
        {
            Console.WriteLine(item);
        }
    }
}