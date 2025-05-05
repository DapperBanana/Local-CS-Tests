
using System;

class HammingDistanceCalculator
{
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

    static void Main()
    {
        string string1 = "karolin";
        string string2 = "karolin";

        int distance = CalculateHammingDistance(string1, string2);

        Console.WriteLine($"The Hamming distance between {string1} and {string2} is {distance}");
    }
}
