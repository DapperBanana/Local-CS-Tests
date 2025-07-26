
using System;

class MainClass {
    public static void Main (string[] args) {
        int[] arr = {10, 22, 9, 33, 21, 50, 41, 60, 80};
        
        int[] dp = new int[arr.Length];
        int[] subSeq = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            dp[i] = 1;
            subSeq[i] = -1;
        }

        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && dp[i] < dp[j] + 1)
                {
                    dp[i] = dp[j] + 1;
                    subSeq[i] = j;
                }
            }
        }

        int maxLength = 0;
        int index = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
                index = i;
            }
        }

        int[] longestSubsequence = new int[maxLength];
        int k = maxLength - 1;
        while (index >= 0)
        {
            longestSubsequence[k] = arr[index];
            k--;
            index = subSeq[index];
        }

        Console.WriteLine("Length of longest increasing subsequence: " + maxLength);
        Console.Write("Longest increasing subsequence: ");
        foreach (int num in longestSubsequence)
        {
            Console.Write(num + " ");
        }
    }
}
