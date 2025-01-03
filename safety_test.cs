
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 5, 7, 8, 9, 10, 11, 15, 17 };
        
        int longestSequenceLength = 0;
        int currentSequenceLength = 1;
        int longestSequenceStartIndex = 0;
        
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1] - 1)
            {
                currentSequenceLength++;
            }
            else
            {
                if (currentSequenceLength > longestSequenceLength)
                {
                    longestSequenceLength = currentSequenceLength;
                    longestSequenceStartIndex = i - currentSequenceLength + 1;
                }
                currentSequenceLength = 1;
            }
        }
        
        if (currentSequenceLength > longestSequenceLength)
        {
            longestSequenceLength = currentSequenceLength;
            longestSequenceStartIndex = numbers.Count - currentSequenceLength;
        }
        
        List<int> longestSequence = numbers.GetRange(longestSequenceStartIndex, longestSequenceLength);
        
        Console.WriteLine("Longest consecutive sequence: " + string.Join(", ", longestSequence));
        Console.WriteLine("Length of longest consecutive sequence: " + longestSequenceLength);
    }
}
