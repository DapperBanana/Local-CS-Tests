
using System;

class Program
{
    static int LongestIncreasingSubsequence(int[] arr)
    {
        int n = arr.Length;
        int[] dp = new int[n];

        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && dp[i] < dp[j] + 1)
                {
                    dp[i] = dp[j] + 1;
                }
            }
        }

        int maxLIS = 0;

        for (int i = 0; i < n; i++)
        {
            if (dp[i] > maxLIS)
            {
                maxLIS = dp[i];
            }
        }

        return maxLIS;
    }

    static void Main()
    {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
        int longestIncreasingSubsequenceLength = LongestIncreasingSubsequence(arr);

        Console.WriteLine("Length of the longest increasing subsequence is: " + longestIncreasingSubsequenceLength);
    }
}
