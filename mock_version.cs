
using System;

class Program
{
    static bool IsCarmichael(int num)
    {
        if (IsPrime(num))
        {
            return false;
        }

        for (int a = 2; a < num; a++)
        {
            if (GCD(a, num) == 1 && ModExp(a, num - 1, num) != 1)
            {
                return false;
            }
        }

        return true;
    }

    static bool IsPrime(int num)
    {
        if (num < 2) 
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
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
        return GCD(b, a % b);
    }

    static int ModExp(int a, int exp, int mod)
    {
        if (exp == 0)
        {
            return 1;
        }
        if (exp % 2 == 0)
        {
            int half = ModExp(a, exp / 2, mod);
            return (half * half) % mod;
        }
        return (a * ModExp(a, exp - 1, mod)) % mod;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsCarmichael(num))
        {
            Console.WriteLine(num + " is a Carmichael number.");
        }
        else
        {
            Console.WriteLine(num + " is not a Carmichael number.");
        }
    }
}
