
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(IsVampireNumber(number))
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
        string numberStr = number.ToString();
        int length = numberStr.Length;

        if(length % 2 != 0)
        {
            return false;
        }
        
        for(int i = (int)Math.Pow(10, length/2 - 1); i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0)
            {
                int factor1 = i;
                int factor2 = number / i;
                string factorStr = (factor1.ToString() + factor2.ToString());

                if (IsSameDigits(numberStr, factorStr))
                {
                    return true;
                }
            }
        }

        return false;
    }

    static bool IsSameDigits(string str1, string str2)
    {
        char[] charArr1 = str1.ToCharArray();
        char[] charArr2 = str2.ToCharArray();

        Array.Sort(charArr1);
        Array.Sort(charArr2);

        return charArr1.SequenceEqual(charArr2);
    }
}
