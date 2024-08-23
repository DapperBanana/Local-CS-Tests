
using System;

class HammingDistance
{
    public static int CalculateHammingDistance(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            throw new ArgumentException("Strings must be of equal length.");
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
        string input1 = "1010101";
        string input2 = "1001001";

        int distance = CalculateHammingDistance(input1, input2);

        Console.WriteLine($"Hamming distance between \"{input1}\" and \"{input2}\" is: {distance}");
    }
}
