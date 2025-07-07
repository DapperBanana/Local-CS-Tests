
using System;

class BinarySearch
{
    static int PerformBinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
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
        int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
        int target = 11;

        int result = PerformBinarySearch(sortedArray, target);

        if (result != -1)
        {
            Console.WriteLine($"Element found at index {result}");
        }
        else
        {
            Console.WriteLine("Element not found in the array");
        }
    }
}
