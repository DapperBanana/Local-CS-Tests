
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 10, 11, 12, 13 };
        
        int maxLength = 1;
        int currentLength = 1;
        int start = numbers[0];
        int end = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == end + 1)
            {
                currentLength++;
                end = numbers[i];
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    start = numbers[i - currentLength];
                }
                currentLength = 1;
                start = numbers[i];
                end = numbers[i];
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            start = numbers[numbers.Count - currentLength];
        }

        Console.WriteLine("Longest consecutive sequence:");
        for (int i = start; i < start + maxLength; i++)
        {
            Console.Write(i + " ");
        }
    }
}
