
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 100, 4, 200, 1, 3, 2 };
        
        Console.WriteLine("Input List: ");
        foreach(int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Longest Consecutive Sequence Length: " + LongestConsecutiveSequence(numbers));
    }

    static int LongestConsecutiveSequence(List<int> numbers)
    {
        HashSet<int> set = new HashSet<int>(numbers);
        int longestSequence = 0;

        foreach(int num in numbers)
        {
            if(!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentSequence = 1;

                while(set.Contains(currentNum + 1))
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
