
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to check if it is a vampire number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsVampireNumber(number))
        {
            Console.WriteLine($"{number} is a vampire number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a vampire number.");
        }
    }

    static bool IsVampireNumber(int number)
    {
        string str = number.ToString();
        if (str.Length % 2 != 0)
        {
            return false;
        }

        List<string> permutations = new List<string>();
        GetPermutations("", str, permutations);

        foreach (var perm in permutations)
        {
            int num1 = int.Parse(perm.Substring(0, str.Length / 2));
            int num2 = int.Parse(perm.Substring(str.Length / 2));

            if ((num1 % 10 == 0 && num2 % 10 == 0) || (num1.ToString().Length != str.Length / 2) || (num2.ToString().Length != str.Length / 2))
            {
                continue;
            }

            if (num1 * num2 == number)
            {
                return true;
            }
        }

        return false;
    }

    static void GetPermutations(string prefix, string remaining, List<string> permutations)
    {
        if (remaining.Length == 0)
        {
            permutations.Add(prefix);
        }

        for (int i = 0; i < remaining.Length; i++)
        {
            GetPermutations(prefix + remaining[i], remaining.Remove(i, 1), permutations);
        }
    }
}
