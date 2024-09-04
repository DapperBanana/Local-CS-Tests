
using System;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        int[] array = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };

        int[] lengths = new int[array.Length];
        int[] sequences = new int[array.Length];

        int maxLength = 1;
        int maxIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            lengths[i] = 1;
            sequences[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (array[i] > array[j] && lengths[i] < lengths[j] + 1)
                {
                    lengths[i] = lengths[j] + 1;
                    sequences[i] = j;
                }
            }

            if (maxLength < lengths[i])
            {
                maxLength = lengths[i];
                maxIndex = i;
            }
        }

        int[] result = new int[maxLength];
        int index = maxLength - 1;
        while (maxIndex >= 0)
        {
            result[index--] = array[maxIndex];
            maxIndex = sequences[maxIndex];
        }

        Console.WriteLine("Longest Increasing Subsequence:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
