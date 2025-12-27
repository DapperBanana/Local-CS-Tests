using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it's a vampire number:");
        string input = Console.ReadLine();
        if (long.TryParse(input, out long number))
        {
            if (IsVampire(number))
                Console.WriteLine($"{number} is a vampire number.");
            else
                Console.WriteLine($"{number} is not a vampire number.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static bool IsVampire(long number)
    {
        string numStr = number.ToString();
        int length = numStr.Length;

        // Vampire numbers have even number of digits
        if (length % 2 != 0 || number < 100)
            return false;

        int halfLength = length / 2;
        var digitCounts = new int[10];
        foreach (char c in numStr)
        {
            digitCounts[c - '0']++;
        }

        // Generate all possible fangs
        // Fangs are numbers with half the number of digits
        for (long fang1 = (long)Math.Pow(10, halfLength - 1); fang1 < (long)Math.Pow(10, halfLength); fang1++)
        {
            if (number % fang1 != 0)
                continue;

            long fang2 = number / fang1;

            // Check if fang2 has the correct number of digits
            if (fang2 < (long)Math.Pow(10, halfLength - 1) || fang2 >= (long)Math.Pow(10, halfLength))
                continue;

            // Fangs should not both end with zero
            if (fang1 % 10 == 0 && fang2 % 10 == 0)
                continue;

            // Compare digit counts
            string combinedFangs = fang1.ToString() + fang2.ToString();
            if (HasSameDigits(numStr, combinedFangs))
                return true;
        }

        return false;
    }

    static bool HasSameDigits(string numStr, string fangsStr)
    {
        int[] countDigits = new int[10];

        foreach (char c in numStr)
            countDigits[c - '0']++;

        foreach (char c in fangsStr)
            countDigits[c - '0']--;

        foreach (int count in countDigits)
            if (count != 0)
                return false;

        return true;
    }
}