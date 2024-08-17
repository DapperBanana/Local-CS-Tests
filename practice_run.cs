
using System;

class HammingDistance
{
    static void Main()
    {
        string str1, str2;
        int distance = 0;

        Console.WriteLine("Enter the first string:");
        str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        str2 = Console.ReadLine();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Error: Strings must be of equal length");
        }
        else
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    distance++;
                }
            }

            Console.WriteLine("Hamming distance between the two strings is: " + distance);
        }
    }
}
