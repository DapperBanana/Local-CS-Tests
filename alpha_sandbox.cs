
using System;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
        int n = arr.Length;

        int[] lis = new int[n];
        for (int i = 0; i < n; i++)
        {
            lis[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
        }

        int maxLength = 0;
        for (int i = 0; i < n; i++)
        {
            maxLength = Math.Max(maxLength, lis[i]);
        }

        Console.WriteLine("The length of the longest increasing subsequence is: " + maxLength);
    }
}
