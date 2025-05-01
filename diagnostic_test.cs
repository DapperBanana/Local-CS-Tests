
using System;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        
        int[] array = new int[length];
        
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        int maxLength = 1;
        int[] lisLength = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            lisLength[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (array[i] > array[j] && lisLength[i] < lisLength[j] + 1)
                {
                    lisLength[i] = lisLength[j] + 1;
                }
            }
            if (maxLength < lisLength[i])
            {
                maxLength = lisLength[i];
            }
        }
        
        Console.WriteLine("The length of the longest increasing subsequence is: " + maxLength);
    }
}
