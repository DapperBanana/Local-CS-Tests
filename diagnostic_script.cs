
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
        string str1 = "karolin";
        string str2 = "kathrin";

        try
        {
            int hammingDistance = CalculateHammingDistance(str1, str2);
            Console.WriteLine("Hamming distance between {0} and {1} is {2}", str1, str2, hammingDistance);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
