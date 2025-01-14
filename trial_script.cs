
using System;
using System.Collections.Generic;

class Program
{
    public static List<int> FindIntersection(List<int> list1, List<int> list2)
    {
        HashSet<int> hashSet = new HashSet<int>(list1);
        hashSet.IntersectWith(list2);
        return new List<int>(hashSet);
    }

    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> intersection = FindIntersection(list1, list2);

        Console.Write("Intersection of the two lists: ");
        foreach (int num in intersection)
        {
            Console.Write(num + " ");
        }
    }
}
