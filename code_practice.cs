
using System;

class LongestIncreasingSubsequence
{
    static int LongestIncreasingSubsequenceLength(int[] arr, int n)
    {
        int[] lis = new int[n];
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            lis[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
            if (max < lis[i])
            {
                max = lis[i];
            }
        }

        return max;
    }

    public static void Main()
    {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
        int n = arr.Length;
        
        int length = LongestIncreasingSubsequenceLength(arr, n);
        
        Console.WriteLine("The length of the longest increasing subsequence is: " + length);
    }
}
