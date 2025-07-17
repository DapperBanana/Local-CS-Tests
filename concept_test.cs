
using System;
using System.Collections.Generic;

class Program
{
    static int LongestConsecutiveSequence(List<int> nums)
    {
        HashSet<int> numSet = new HashSet<int>();
        foreach (int num in nums)
        {
            numSet.Add(num);
        }

        int longestSequence = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentSequence = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentSequence++;
                }

                longestSequence = Math.Max(longestSequence, currentSequence);
            }
        }

        return longestSequence;
    }

    static void Main()
    {
        List<int> nums = new List<int> { 100, 4, 200, 1, 3, 2 };

        int longestSequence = LongestConsecutiveSequence(nums);

        Console.WriteLine("The longest consecutive sequence is: " + longestSequence);
    }
}
