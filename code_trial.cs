
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 4, 5, 6, 8, 9, 10, 11, 12, 15, 16, 18, 19, 20 };

        int longestSequenceLength = FindLongestConsecutiveSequence(numbers);
        Console.WriteLine("Longest consecutive sequence length: " + longestSequenceLength);
    }

    static int FindLongestConsecutiveSequence(List<int> numbers)
    {
        HashSet<int> set = new HashSet<int>(numbers);
        int longestSequence = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentSeq = 1;

                while (set.Contains(num + currentSeq))
                {
                    currentSeq++;
                }

                longestSequence = Math.Max(longestSequence, currentSeq);
            }
        }

        return longestSequence;
    }
}
