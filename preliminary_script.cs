
using System;

class CarmichaelNumberChecker
{
    static bool IsCarmichaelNumber(int number)
    {
        if (IsPrime(number))
        {
            return false;
        }

        for (int a = 2; a < number; a++)
        {
            if (GreatestCommonDivisor(a, number) == 1)
            {
                if (ModularExponentiation(a, number - 1, number) != 1)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    static int ModularExponentiation(int baseNum, int exponent, int modulus)
    {
        int result = 1;
        baseNum = baseNum % modulus;

        while (exponent > 0)
        {
            if (exponent % 2 == 1)
            {
                result = (result * baseNum) % modulus;
            }

            exponent = exponent >> 1;
            baseNum = (baseNum * baseNum) % modulus;
        }

        return result;
    }

    static void Main()
    {
        int n = 561; // Example Carmichael number
        
        if (IsCarmichaelNumber(n))
        {
            Console.WriteLine(n + " is a Carmichael number.");
        }
        else
        {
            Console.WriteLine(n + " is not a Carmichael number.");
        }
    }
}
