
using System;

class Program
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int target = 14;

        int index = BinarySearch(arr, target);
        
        if (index != -1)
            Console.WriteLine($"Target {target} found at index {index}");
        else
            Console.WriteLine($"Target {target} not found in the list");
    }
}
