
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 10, 11 };

        int currentSequence = 1;
        int longestSequence = 1;
        int startNumber = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == numbers[i - 1] + 1)
            {
                currentSequence++;
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    startNumber = numbers[i - currentSequence + 1];
                }
            }
            else
            {
                currentSequence = 1;
            }
        }

        Console.WriteLine($"The longest consecutive sequence is {longestSequence}, starting from {startNumber}");

    }
}
