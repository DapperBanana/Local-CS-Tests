
using System;

class Program
{
    static void Main()
    {
        string input;
        Console.WriteLine("Enter a string: ");
        input = Console.ReadLine();

        int count = CountVowels(input);

        Console.WriteLine("Number of vowels in the input string: " + count);
    }

    static int CountVowels(string inputString)
    {
        int count = 0;
        foreach (char c in inputString)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                count++;
            }
        }
        return count;
    }
}
