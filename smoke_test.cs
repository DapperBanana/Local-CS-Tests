
using System;

class Program
{
    static bool IsCarmichaelNumber(int n)
    {
        if (IsPrime(n)) return false;

        for (int a = 2; a < n; a++)
        {
            if (Gcd(a, n) == 1)
            {
                if (ModularExponentiation(a, n - 1, n) != 1)
                {
                    return false;
                }
            }
        }

        return true;
    }

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

    static int Gcd(int a, int b)
    {
        if (b == 0) return a;
        return Gcd(b, a % b);
    }

    static int ModularExponentiation(int a, int b, int n)
    {
        int result = 1;

        while (b > 0)
        {
            if ((b % 2) == 1)
            {
                result = (result * a) % n;
            }

            a = (a * a) % n;
            b >>= 1;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

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
