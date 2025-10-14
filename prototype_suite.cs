
using System;

class HammingDistanceCalculator
{
    static void Main()
    {
        // Input two strings
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        // Calculate Hamming distance
        int hammingDistance = CalculateHammingDistance(str1, str2);

        // Output the result
        Console.WriteLine($"Hamming distance between the two strings is: {hammingDistance}");
    }

    static int CalculateHammingDistance(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            throw new ArgumentException("Strings must be of equal length");
        }

        int distance = 0;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                distance++;
            }
        }

        return distance;
    }
}
