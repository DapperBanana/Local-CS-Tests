
using System;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };

        int[] lis = new int[arr.Length];
        int maxLength = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            lis[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                    if (lis[i] > maxLength)
                    {
                        maxLength = lis[i];
                    }
                }
            }
        }

        Console.WriteLine("Length of Longest Increasing Subsequence: " + maxLength);
    }
}
