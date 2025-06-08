
using System;
using System.Collections.Generic;

class Program
{
    static int BinarySearch(List<int> list, int target)
    {
        int min = 0;
        int max = list.Count - 1;

        while (min <= max)
        {
            int mid = min + (max - min) / 2;

            if (list[mid] == target)
            {
                return mid;
            }
            else if (list[mid] < target)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        List<int> list = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int target = 11;

        int index = BinarySearch(list, target);

        if (index != -1)
        {
            Console.WriteLine($"{target} found at index {index}");
        }
        else
        {
            Console.WriteLine($"{target} not found in the list");
        }
    }
}
