
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> intersection = list1.Intersect(list2).ToList();

        Console.WriteLine("Intersection of list1 and list2:");
        foreach (int item in intersection)
        {
            Console.WriteLine(item);
        }
    }
}
