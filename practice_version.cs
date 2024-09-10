
using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };

        int length = array.Length;
        int[] dp = new int[length];
        int[] prev = new int[length];

        for (int i = 0; i < length; i++)
        {
            dp[i] = 1;
            prev[i] = -1;
        }

        for (int i = 1; i < length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i] > array[j] && dp[i] < dp[j] + 1)
                {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;
                }
            }
        }

        int maxLength = 0;
        int maxIndex = 0;

        for (int i = 0; i < length; i++)
        {
            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
                maxIndex = i;
            }
        }

        Console.WriteLine("Length of longest increasing subsequence: " + maxLength);

        Console.Write("Longest increasing subsequence: ");
        PrintLIS(array, prev, maxIndex);
    }

    static void PrintLIS(int[] array, int[] prev, int index)
    {
        if (index == -1)
        {
            return;
        }

        PrintLIS(array, prev, prev[index]);
        Console.Write(array[index] + " ");
    }
}
