
using System;
using System.Collections.Generic;

class Program
{
    static List<int> MergeSortedLists(List<int> list1, List<int> list2)
    {
        List<int> mergedList = new List<int>();
        int index1 = 0;
        int index2 = 0;

        while (index1 < list1.Count && index2 < list2.Count)
        {
            if (list1[index1] < list2[index2])
            {
                mergedList.Add(list1[index1]);
                index1++;
            }
            else
            {
                mergedList.Add(list2[index2]);
                index2++;
            }
        }

        for (int i = index1; i < list1.Count; i++)
        {
            mergedList.Add(list1[i]);
        }

        for (int i = index2; i < list2.Count; i++)
        {
            mergedList.Add(list2[i]);
        }

        return mergedList;
    }

    static void Main()
    {
        List<int> list1 = new List<int> { 1, 3, 5, 7, 9 };
        List<int> list2 = new List<int> { 2, 4, 6, 8, 10 };

        List<int> mergedList = MergeSortedLists(list1, list2);

        foreach (int num in mergedList)
        {
            Console.Write(num + " ");
        }
        
        // Output: 1 2 3 4 5 6 7 8 9 10
    }
}
