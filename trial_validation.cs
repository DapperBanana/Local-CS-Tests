using System;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "1011101";
        string str2 = "1001001";

        int distance = HammingDistance(str1, str2);
        Console.WriteLine($"Hamming Distance: {distance}");
    }

    static int HammingDistance(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            throw new ArgumentException("Strings must be of equal length.");

        int distance = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
                distance++;
        }
        return distance;
    }
}