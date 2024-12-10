
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> commonElements = new List<int>();

        foreach (var item in list1)
        {
            if (list2.Contains(item))
            {
                commonElements.Add(item);
            }
        }

        Console.WriteLine("Common Elements between the two lists:");

        foreach (var item in commonElements)
        {
            Console.WriteLine(item);
        }
    }
}
