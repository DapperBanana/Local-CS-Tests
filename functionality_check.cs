
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        var intersection = list1.Intersect(list2);

        Console.WriteLine("Intersection of List 1 and List 2:");
        foreach (var item in intersection)
        {
            Console.WriteLine(item);
        }
    }
}
