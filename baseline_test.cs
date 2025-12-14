using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = new List<int> { 100, 4, 200, 1, 3, 2 };
        int longestSequenceLength = FindLongestConsecutiveSequence(nums);
        Console.WriteLine($"Longest consecutive sequence length: {longestSequenceLength}");
    }

    static int FindLongestConsecutiveSequence(List<int> nums)
    {
        if (nums == null || nums.Count == 0)
            return 0;

        HashSet<int> numSet = new HashSet<int>(nums);
        int maxLength = 0;

        foreach (int num in numSet)
        {
            // Only start counting if this is the start of a sequence
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentLength = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentLength++;
                }

                maxLength = Math.Max(maxLength, currentLength);
            }
        }

        return maxLength;
    }
}