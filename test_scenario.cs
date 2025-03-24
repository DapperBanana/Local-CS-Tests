
using System;

class BinarySearch
{
    static int binarySearch(int[] arr, int target)
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

    public static void Main()
    {
        int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        int target = 16;
        int result = binarySearch(arr, target);

        if (result != -1)
        {
            Console.WriteLine("Element found at index " + result);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}
