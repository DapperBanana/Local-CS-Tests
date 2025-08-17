
using System;

class Program
{
    static bool IsIsogram(string str)
    {
        str = str.ToLower(); // Convert the string to lowercase
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main()
    {
        string input = "hello";

        if (IsIsogram(input))
        {
            Console.WriteLine($"{input} is an isogram.");
        }
        else
        {
            Console.WriteLine($"{input} is not an isogram.");
        }
    }
}
