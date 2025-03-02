
using System;

class BinarySearchExample
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

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
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int target = 13;

        int index = BinarySearch(arr, target);

        if (index != -1)
        {
            Console.WriteLine("Element found at index: " + index);
        }
        else
        {
            Console.WriteLine("Element not found in the array");
        }
    }
}
