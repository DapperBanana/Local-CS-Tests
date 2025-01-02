
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> commonElements = list1.Intersect(list2).ToList();

        Console.WriteLine("Common Elements:");
        foreach (var element in commonElements)
        {
            Console.WriteLine(element);
        }
    }
}
