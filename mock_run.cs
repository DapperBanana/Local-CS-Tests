
using System;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        int[] array = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };

        int[] lis = new int[array.Length];
        int maxLength = 1;

        for (int i = 0; i < array.Length; i++)
        {
            lis[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (array[i] > array[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
            maxLength = Math.Max(maxLength, lis[i]);
        }

        int[] result = new int[maxLength];
        int length = maxLength;
        for (int i = array.Length - 1; i >= 0 && length > 0; i--)
        {
            if (lis[i] == length)
            {
                result[length - 1] = array[i];
                length--;
            }
        }

        Console.WriteLine("Longest Increasing Subsequence:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
