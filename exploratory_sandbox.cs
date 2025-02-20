
using System;

class Program
{
    static int LongestIncreasingSubsequence(int[] arr)
    {
        int n = arr.Length;
        int[] lis = new int[n];

        lis[0] = 1;

        for (int i = 1; i < n; i++)
        {
            lis[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
        }

        int max = lis[0];
        for (int i = 1; i < n; i++)
        {
            if (lis[i] > max)
            {
                max = lis[i];
            }
        }

        return max;
    }

    static void Main()
    {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
        
        Console.WriteLine("Length of Longest Increasing Subsequence: " + LongestIncreasingSubsequence(arr));
    }
}
