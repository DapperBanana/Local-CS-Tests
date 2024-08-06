
using System;
using System.Collections.Generic;

class Program
{
    static List<int> MergeSortedLists(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();
        int i = 0;
        int j = 0;

        while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] < list2[j])
            {
                result.Add(list1[i]);
                i++;
            }
            else
            {
                result.Add(list2[j]);
                j++;
            }
        }

        while (i < list1.Count)
        {
            result.Add(list1[i]);
            i++;
        }

        while (j < list2.Count)
        {
            result.Add(list2[j]);
            j++;
        }

        return result;
    }

    static void Main()
    {
        List<int> list1 = new List<int> { 1, 3, 5, 7, 9 };
        List<int> list2 = new List<int> { 2, 4, 6, 8, 10 };

        List<int> sortedList = MergeSortedLists(list1, list2);

        Console.WriteLine("Merged Sorted List:");
        foreach (int num in sortedList)
        {
            Console.WriteLine(num);
        }
    }
}
