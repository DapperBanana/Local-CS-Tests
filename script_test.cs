
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool IsVampireNumber(int number)
    {
        string numStr = number.ToString();
        if (numStr.Length % 2 != 0)
        {
            return false;
        }

        var numChars = numStr.ToList();
        var permutations = GetPermutations(numChars);
        
        foreach (var perm in permutations)
        {
            string result = string.Join("", perm);
            if (result[0] != '0')
            {
                int factor1 = int.Parse(result.Substring(0, numStr.Length / 2));
                int factor2 = int.Parse(result.Substring(numStr.Length / 2));

                if (factor1 * factor2 == number)
                {
                    return true;
                }
            }
        }

        return false;
    }

    static List<List<T>> GetPermutations<T>(List<T> list)
    {
        if (list.Count == 1)
        {
            return new List<List<T>>() { list };
        }

        var permutations = new List<List<T>>();
        var subPermutations = GetPermutations(list.GetRange(1, list.Count - 1));

        foreach (var perm in subPermutations)
        {
            for (int i = 0; i <= perm.Count; i++)
            {
                var newPerm = new List<T>(perm);
                newPerm.Insert(i, list[0]);
                permutations.Add(newPerm);
            }
        }

        return permutations;
    }

    static void Main()
    {
        int number = 1260;

        if (IsVampireNumber(number))
        {
            Console.WriteLine($"{number} is a vampire number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a vampire number.");
        }
    }
}
