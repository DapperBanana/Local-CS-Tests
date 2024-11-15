
using System;

class Program
{
    static int HammingDistance(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            throw new ArgumentException("The two strings must have the same length");
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

        Console.WriteLine($"Hamming distance between {str1} and {str2} is: {HammingDistance(str1, str2)}");
    }
}
