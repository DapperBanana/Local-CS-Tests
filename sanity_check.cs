
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        var intersection = list1.Intersect(list2);

        Console.WriteLine("Intersection of the two lists:");
        foreach (var item in intersection)
        {
            Console.WriteLine(item);
        }
    }
}
