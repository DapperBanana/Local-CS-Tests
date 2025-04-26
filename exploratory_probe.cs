
using System;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        int[] arr = { 3, 10, 2, 1, 20 };
        int n = arr.Length;

        int[] lis = new int[n];
        int i, j, maxLen = 0;

        for (i = 0; i < n; i++)
        {
            lis[i] = 1;
        }

        for (i = 1; i < n; i++)
        {
            for (j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
        }

        for (i = 0; i < n; i++)
        {
            if (maxLen < lis[i])
            {
                maxLen = lis[i];
            }
        }

        Console.WriteLine("Length of Longest Increasing Subsequence is: " + maxLen);
    }
}
