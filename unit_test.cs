
using System;

class CarmichaelNumberChecker
{
    static bool IsCarmichaelNumber(int n)
    {
        if (n < 2)
            return false;
        
        for (int a = 2; a < n; a++)
        {
            if (GCD(a, n) != 1)
                continue;
            
            if (ModularExponentiation(a, n - 1, n) != 1)
                return false;
        }
        
        return true;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int ModularExponentiation(int baseNum, int exp, int mod)
    {
        int result = 1;
        baseNum = baseNum % mod;

        while (exp > 0)
        {
            if (exp % 2 == 1)
                result = (result * baseNum) % mod;
            
            exp = exp >> 1;
            baseNum = (baseNum * baseNum) % mod;
        }

        return result;
    }

    static void Main()
    {
        int number = 561; // Example Carmichael number
        if (IsCarmichaelNumber(number))
            Console.WriteLine($"{number} is a Carmichael number.");
        else
            Console.WriteLine($"{number} is not a Carmichael number.");
    }
}
