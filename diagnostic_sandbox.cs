
using System;

class Program
{
    static void Main()
    {
        int number = 1260; // change this to the number you want to check
        
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
        string numString = number.ToString();
        int numLength = numString.Length;

        if (numLength % 2 != 0)
        {
            return false;
        }

        for (int i = (int)Math.Pow(10, numLength / 2 - 1); i < Math.Pow(10, numLength / 2); i++)
        {
            int factor1 = i;
            int factor2 = number / i;

            if (factor1 * factor2 == number && IsSameDigits(numString, factor1.ToString() + factor2.ToString()))
            {
                return true;
            }
        }

        return false;
    }

    static bool IsSameDigits(string str1, string str2)
    {
        char[] charArray1 = str1.ToCharArray();
        char[] charArray2 = str2.ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

        return new string(charArray1) == new string(charArray2);
    }
}
