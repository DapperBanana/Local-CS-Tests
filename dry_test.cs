
using System;

class LongestIncreasingSubsequence
{
    static int LongestIncreasingSubsequenceLength(int[] nums, int n)
    {
        int[] lis = new int[n];
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            lis[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j] && lis[i] < lis[j] + 1)
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

    static void Main()
    {
        int[] nums = {10, 22, 9, 33, 21, 50, 41, 60};
        int n = nums.Length;

        Console.WriteLine("Length of longest increasing subsequence: " + LongestIncreasingSubsequenceLength(nums, n));
    }
}
