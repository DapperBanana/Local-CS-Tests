
using System;

class CarmichaelNumberChecker
{
    static bool IsCarmichaelNumber(int n)
    {
        if (n <= 2)
        {
            return false;
        }

        for (int a = 2; a < n; a++)
        {
            if (GCD(a, n) == 1 && ModuloPower(a, n - 1, n) != 1)
            {
                return false;
            }
        }

        return true;
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GCD(b, a % b);
        }
    }

    static int ModuloPower(int baseNum, int exponent, int modulo)
    {
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result = (result * baseNum) % modulo;
        }
        return result;
    }

    static void Main()
    {
        int number = 561; // example Carmichael number

        if (IsCarmichaelNumber(number))
        {
            Console.WriteLine($"{number} is a Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Carmichael number.");
        }
    }
}
