
using System;

class Program
{
    static void Main()
    {
        int number = 1260; // Change this to the number you want to check
        
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
        string numStr = number.ToString();
        int len = numStr.Length;

        if (len % 2 != 0)
        {
            return false;
        }

        for (int i = (int)Math.Pow(10, len / 2 - 1); i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                int factor1 = i;
                int factor2 = number / i;

                string factorStr = factor1.ToString() + factor2.ToString();
                char[] numArr = numStr.ToCharArray();
                Array.Sort(numArr);
                char[] factorArr = factorStr.ToCharArray();
                Array.Sort(factorArr);

                if (new string(numArr) == new string(factorArr))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
