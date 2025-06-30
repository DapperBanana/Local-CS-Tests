
using System;
using System.Collections.Generic;

class Program
{
    static int BinarySearch(List<int> arr, int target)
    {
        int left = 0;
        int right = arr.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        int target = 13;
        int index = BinarySearch(numbers, target);

        if (index != -1)
        {
            Console.WriteLine($"The target {target} was found at index {index}");
        }
        else
        {
            Console.WriteLine("The target was not found in the list");
        }
    }
}
