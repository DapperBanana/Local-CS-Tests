
using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;

        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }

        return true;
    }

    static int PowerMod(int a, int b, int mod)
    {
        int result = 1;

        while (b > 0)
        {
            if (b % 2 == 1)
            {
                result = (result * a) % mod;
            }

            a = (a * a) % mod;
            b /= 2;
        }

        return result;
    }

    static bool IsLucasCarmichael(int n)
    {
        if (IsPrime(n)) return false;

        for (int a = 2; a < n; a++)
        {
            if ((PowerMod(a, n - 1, n) != 1))
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsLucasCarmichael(number))
        {
            Console.WriteLine("{0} is a Lucas-Carmichael number.", number);
        }
        else
        {
            Console.WriteLine("{0} is not a Lucas-Carmichael number.", number);
        }
    }
}
