
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        if (IsVampireNumber(number))
        {
            Console.WriteLine($"{number} is a vampire number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a vampire number.");
        }
    }

    static bool IsVampireNumber(long number)
    {
        string numStr = number.ToString();
        if (numStr.Length % 2 != 0)
        {
            return false;
        }

        List<string> perms = new List<string>();

        GetPerms("", numStr, perms);

        foreach (var perm in perms)
        {
            string fangs1 = perm.Substring(0, numStr.Length / 2);
            string fangs2 = perm.Substring(numStr.Length / 2);

            if (fangs1[0] == '0' && fangs1.Length > 1 && fangs2[0] == '0' && fangs2.Length > 1)
            {
                continue; //avoid leading zeros
            }

            long factor1 = long.Parse(fangs1);
            long factor2 = long.Parse(fangs2);

            if (factor1 * factor2 == number)
            {
                return true;
            }
        }

        return false;
    }

    static void GetPerms(string prefix, string remaining, List<string> perms)
    {
        if (remaining.Length == 0)
        {
            perms.Add(prefix);
        }

        for (int i = 0; i < remaining.Length; i++)
        {
            GetPerms(prefix + remaining[i], remaining.Remove(i, 1), perms);
        }
    }
}
