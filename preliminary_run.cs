
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 14 };

        List<int> longestSeq = FindLongestConsecutiveSequence(numbers);

        Console.WriteLine("Longest Consecutive Sequence: ");
        foreach (int num in longestSeq)
        {
            Console.Write(num + " ");
        }
    }

    static List<int> FindLongestConsecutiveSequence(List<int> numbers)
    {
        List<int> longestSeq = new List<int>();
        HashSet<int> numSet = new HashSet<int>(numbers);

        foreach (int num in numbers)
        {
            if (!numSet.Contains(num - 1)) // Check if current number is the start of a sequence
            {
                int currentNum = num;
                List<int> currentSeq = new List<int> { currentNum };

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentSeq.Add(currentNum);
                }

                if (currentSeq.Count > longestSeq.Count)
                {
                    longestSeq = new List<int>(currentSeq);
                }
            }
        }

        return longestSeq;
    }
}
