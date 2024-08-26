
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> commonElements = FindCommonElements(list1, list2);

        Console.WriteLine("Common elements between the two lists are:");
        foreach (int element in commonElements)
        {
            Console.WriteLine(element);
        }
    }

    static List<int> FindCommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set = new HashSet<int>(list1);
        List<int> commonElements = new List<int>();

        foreach (int item in list2)
        {
            if (set.Contains(item))
            {
                commonElements.Add(item);
            }
        }

        return commonElements;
    }
}
