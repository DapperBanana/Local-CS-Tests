
using System;

class BinarySearchProgram
{
    static int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == x)
                return mid;

            if (arr[mid] < x)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18};
        int x = 12;

        int result = BinarySearch(arr, x);
        if (result == -1)
            Console.WriteLine("Element not found");
        else
            Console.WriteLine("Element found at index " + result);
    }
}
