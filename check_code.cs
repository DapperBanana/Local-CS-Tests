
using System;
using System.Collections.Generic;

class Program
{
    static int LongestConsecutiveSequence(List<int> numbers)
    {
        HashSet<int> numSet = new HashSet<int>(numbers);
        int maxLength = 0;

        foreach (int num in numSet)
        {
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

    static void Main()
    {
        List<int> numbers = new List<int> { 100, 4, 200, 1, 3, 2 };
        int longestSequenceLength = LongestConsecutiveSequence(numbers);
        
        Console.WriteLine("The longest consecutive sequence length is: " + longestSequenceLength);
    }
}
