
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 10, 11, 12 };

        int longestSequenceLength = FindLongestConsecutiveSequence(numbers);
        
        Console.WriteLine("The longest consecutive sequence has length: " + longestSequenceLength);
    }
    
    static int FindLongestConsecutiveSequence(List<int> numbers)
    {
        HashSet<int> numSet = new HashSet<int>();
        foreach (int num in numbers)
        {
            numSet.Add(num);
        }
        
        int longestSequence = 0;
        foreach (int num in numbers)
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
}
